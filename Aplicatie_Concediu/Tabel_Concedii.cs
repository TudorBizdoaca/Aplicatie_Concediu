using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatie_Concediu
{
    public partial class Tabel_Concedii : Form
    {
        static readonly HttpClient client = new HttpClient();
        List<Concediu> listaConcedii = new List<Concediu>();
        List<StareConcediu> listaStariConcedii = new List<StareConcediu>();
        List<string[]> randGv = new List<string[]>();
        public Tabel_Concedii()
        {
            InitializeComponent();
        }


        private void populareGridView(List<Concediu> concedii)
        {
            dgvTabelConcedii.ColumnCount = 8;
            dgvTabelConcedii.Columns[0].Name = "Nume";
            dgvTabelConcedii.Columns[1].Name = "Prenume";
            dgvTabelConcedii.Columns[2].Name = "Manager";
            dgvTabelConcedii.Columns[3].Name = "Tip Concediu";
            dgvTabelConcedii.Columns[4].Name = "Inlocuitor";
            dgvTabelConcedii.Columns[5].Name = "Data Inceput";
            dgvTabelConcedii.Columns[6].Name = "Data Final";
            dgvTabelConcedii.Columns[7].Name = "Stare cerere concediu";

            int i = 0;
            string[] row = new string[] { };
            Dictionary<string, string> dictionarConcedii = new Dictionary<string, string>();
            foreach (Concediu c in concedii)
            {
                if (c != null)
                {
                    row = new string[] {c.Angajat.Nume,c.Angajat.Prenume,
                  c.Angajat.Manager.Nume!=null?c.Angajat.Manager.Nume + " "+c.Angajat.Manager.Prenume:"Nu are manager"
                  ,c.TipConcediu.Nume,c.Inlocuitor.Nume+" "+c.Inlocuitor.Prenume,c.DataInceput.ToString("dd/MM/yyyy"),c.DataSfarsit.ToString("dd/MM/yyyy"),c.StareConcediu.Nume};
                }
                int rowIndex = 0;
                rowIndex = dgvTabelConcedii.Rows.Add(row);
                if (dgvTabelConcedii.Rows.Count > 0)
                {

                    dgvTabelConcedii.Rows[rowIndex].Tag = c.Id;
                }


            }
        }

        private async Task GetConcedii(string requestUrl)
        {
            HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            listaConcedii.Clear();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
            dgvTabelConcedii.Rows.Clear();
            populareGridView(listaConcedii);

        }

        private async Task GetConcediiDupaNumeAngajat(string numeAngajat)
        {
            HttpResponseMessage response = await client.GetAsync(String.Format("http://localhost:5085/api/TabelConcedii/GetConcediiDupaNumeAngajat?nume={0}", numeAngajat));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            listaConcedii.Clear();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
            dgvTabelConcedii.Rows.Clear();
            populareGridView(listaConcedii);
        }
        private async Task GetStariConcediu()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5085/api/TabelConcedii/GetStariConcedii");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            listaStariConcedii = JsonConvert.DeserializeObject<List<StareConcediu>>(responseBody);
        }
        private async void populareComboBox()
        {
            StareConcediu sToate = new StareConcediu();

            await GetStariConcediu();

            cbStariConcedii.ValueMember = "Id";
            cbStariConcedii.DisplayMember = "Nume";
            sToate.Id = 0;
            sToate.Nume = "Toate";
            listaStariConcedii.Add(sToate);
            cbStariConcedii.SelectedValue = sToate.Id.ToString();
            cbStariConcedii.DataSource = listaStariConcedii;

            cbStariConcedii.SelectedIndex = cbStariConcedii.Items.Count - 1;
        }
        private async void Tabel_Concedii_Load(object sender, EventArgs e)
        {

            populareComboBox();
            Program.EsteAdmin = Convert.ToInt32(SesiuneLogIn.angajatLogat.EsteAdmin);

            if (Program.EsteAdmin == 1 && cbStariConcedii.SelectedIndex == cbStariConcedii.Items.Count - 1)
            {

                await GetConcedii("http://localhost:5085/api/TabelConcedii/GetConcedii");
            }
            else
            {
                MessageBox.Show("Doar Administratorii pot accesa acest camp");
            }



        }

        private void dgvTabelConcedii_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdConcediu = this.dgvTabelConcedii.CurrentRow.Tag.ToString();
            PaginaDetalii paginaDetalii = new PaginaDetalii(this);
            paginaDetalii.Show();
        }
        private async Task GetConcediiByStare(int stareId)
        {
            listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("http://localhost:5085/api/TabelConcedii/GetConcediiByStareId?stareId={0}", stareId));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        }

        public async void repopulareGV()
        {
            dgvTabelConcedii.Rows.Clear();
            await GetConcediiByStare((int)cbStariConcedii.SelectedValue);
            populareGridView(listaConcedii);
        }

        private async void cbStariConcedii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbStariConcedii.SelectedValue.ToString() != "0")
                repopulareGV();
            else
            {
                await GetConcedii("http://localhost:5085/api/TabelConcedii/GetConcedii");
                listaConcedii.Clear();
                populareGridView(listaConcedii);
            }
        }

        private void tbFiltrareNume_TextChanged(object sender, EventArgs e)
        {
            if (tbFiltrareNume.Text.Length >= 5)
            {
                //  await GetConcediiDupaNumeAngajat(tbFiltrareNume.Text);
            }

        }

        private async void tbFiltrareNume_Leave(object sender, EventArgs e)
        {
            dgvTabelConcedii.Rows.Clear();
            await GetConcediiDupaNumeAngajat(tbFiltrareNume.Text);

        }
    }
}
