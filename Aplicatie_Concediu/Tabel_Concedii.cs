using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Tabel_Concedii : Form
    {
        static readonly HttpClient client = new HttpClient();
        List<Concediu> listaConcedii = new List<Concediu>();
        List<StareConcediu> listaStariConcedii = new List<StareConcediu>();
        List<TipConcediu> listaTipuriConcedii = new List<TipConcediu>();
        bool dataInceputSelectata = false;
        bool dataFinalSelectata = false;
       
        public Tabel_Concedii()
        {
            InitializeComponent();
        }


        public void populareGridView(List<Concediu> concedii)
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

    
            string[] row = new string[] { };
            
            foreach (Concediu c in concedii)
            {
                if(c != null) { 
                  row = new string[] {c.Angajat.Nume,c.Angajat.Prenume,
                  c.Angajat.Manager.Nume!=null?c.Angajat.Manager.Nume + " "+c.Angajat.Manager.Prenume:"Nu are manager"
                  ,c.TipConcediu.Nume,c.Inlocuitor.Nume+" "+c.Inlocuitor.Prenume,c.DataInceput.ToString("dd/MM/yyyy"),c.DataSfarsit.ToString("dd/MM/yyyy"),c.StareConcediu.Nume};
                }
                int rowIndex = 0;  
                rowIndex  = dgvTabelConcedii.Rows.Add(row);
                if(dgvTabelConcedii.Rows.Count > 0)
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
            string URL = String.Format("{0}/TabelConcedii/GetConcediiDupaNumeAngajat?nume={1}", SesiuneLogIn.requestURL, numeAngajat);

            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            listaConcedii.Clear();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
            populareGridView(listaConcedii);
        }
        private async Task GetStariConcediu()
        {
            string URL = String.Format("{0}/TabelConcedii/GetStariConcedii", SesiuneLogIn.requestURL);

            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            
            listaStariConcedii = JsonConvert.DeserializeObject<List<StareConcediu>>(responseBody);
        }

        private async Task getTipuriConcediu()
        {
            HttpResponseMessage response = await client.GetAsync(String.Format("{0}/TabelConcedii/GetTipConcedii",SesiuneLogIn.requestURL));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            listaTipuriConcedii = JsonConvert.DeserializeObject<List<TipConcediu>>(responseBody);
        }
        private async void populareComboBox()
        { 
            StareConcediu sToate = new StareConcediu();
            TipConcediu tToate = new TipConcediu();
            await GetStariConcediu();
            await getTipuriConcediu();
            tToate.Id = 0;
            tToate.Nume = "Toate";
            sToate.Id = 0;
            sToate.Nume = "Toate";

            cbStariConcedii.ValueMember ="Id";
            cbStariConcedii.DisplayMember = "Nume";
            
            listaStariConcedii.Add(sToate);
            cbStariConcedii.SelectedValue = sToate.Id.ToString();
            cbStariConcedii.DataSource = listaStariConcedii;
        
            cbStariConcedii.SelectedIndex = cbStariConcedii.Items.Count-1;

            cbTipConcedii.ValueMember = "Id";
            cbTipConcedii.DisplayMember = "Nume";
            listaTipuriConcedii.Add(tToate);
            cbTipConcedii.SelectedValue = tToate.Id.ToString();
            cbTipConcedii.DataSource = listaTipuriConcedii;
            cbTipConcedii.SelectedIndex = cbStariConcedii.Items.Count - 1;
        }
        private async void Tabel_Concedii_Load(object sender, EventArgs e)
        {

            populareComboBox();
            Program.EsteAdmin = Convert.ToInt32(SesiuneLogIn.angajatLogat.EsteAdmin);
         
            if (Program.EsteAdmin == 1 && cbStariConcedii.SelectedIndex == cbStariConcedii.Items.Count - 1)
            {
                string URL = String.Format("{0}/TabelConcedii/GetConcedii", SesiuneLogIn.requestURL);

                await GetConcedii(URL);
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

            string URL = String.Format("{0}/TabelConcedii/GetConcediiByStareId?stareId={1}", SesiuneLogIn.requestURL, stareId);

            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        }

        private async Task GetConcediiByTip(int tipId)
        {
            listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("{0}/TabelConcedii/GetConcediiByTipConcediuId?tipConcediuId={1}", SesiuneLogIn.requestURL,tipId));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        }

        public async void repopulareGvDupaSelectStare()
        {
            dgvTabelConcedii.Rows.Clear();
            await GetConcediiByStare((int)cbStariConcedii.SelectedValue);
            populareGridView(listaConcedii);
        }
       
        private async void cbStariConcedii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbStariConcedii.SelectedValue.ToString() !="0")
                 repopulareGvDupaSelectStare();
            else
            {
                string URL = String.Format("{0}/TabelConcedii/GetConcedii", SesiuneLogIn.requestURL);

                await GetConcedii(URL);
                listaConcedii.Clear();
                populareGridView(listaConcedii);
            }
        }

        private async void tbFiltrareNume_Leave(object sender, EventArgs e)
        {
            dgvTabelConcedii.Rows.Clear();
            await GetConcediiDupaNumeAngajat(tbFiltrareNume.Text);
            
        }
        private async Task GetConcediiCuFiltre(string nume,int? stareId, int? tipId, DateTime? dataInceput, DateTime? dataFinal)
        {
            listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("{0}/TabelConcedii/GetConcediiDupaFiltre?nume={1}&stareId={2}&tipId={3}&dataInceput={4}&dataFinal={5}",SesiuneLogIn.requestURL, nume, stareId,tipId,dataInceput,dataFinal));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        }

        private async void cbTipConcedii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipConcedii.SelectedValue.ToString() != "0")
            {
                dgvTabelConcedii.Rows.Clear();
                await GetConcediiByTip((int)cbTipConcedii.SelectedValue);
                populareGridView(listaConcedii);
            }
            else
            {
                await GetConcedii(String.Format("{0}/TabelConcedii/GetConcedii",SesiuneLogIn.requestURL));
                listaConcedii.Clear();
                populareGridView(listaConcedii);
            }
        }

        private async void btnAplicaFiltre_Click(object sender, EventArgs e)
        {
            string nume;
            if (!String.IsNullOrEmpty(tbFiltrareNume.Text) || !String.IsNullOrWhiteSpace(tbFiltrareNume.Text))
            {
                nume = tbFiltrareNume.Text;
            } else
            {
                nume = null;
            }

            int? stareId;
            stareId = Convert.ToInt32(cbStariConcedii.SelectedValue);
    
                    
            int? tipId;
            tipId = Convert.ToInt32(cbTipConcedii.SelectedValue);

            DateTime? dataInceput = null;
            DateTime? dataFinal = null;
            if(dataInceputSelectata && dataFinalSelectata)
            {
                dataInceput = dtpDataInceput.Value;
            }
            else
            {
                dataFinal = dtpDataFinal.Value;
            }

            dgvTabelConcedii.Rows.Clear();
        
            await GetConcediiCuFiltre(nume, stareId, tipId, dataInceput, dtpDataFinal.Value);

        
            populareGridView(listaConcedii);

        }

        private void dtpDataInceput_ValueChanged(object sender, EventArgs e)
        {
            dataInceputSelectata = true;
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            dataFinalSelectata = true;
        }
    }
}