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

namespace Aplicatie_Concediu
{
    public partial class Tabel_Concedii : Form
    {
        static readonly HttpClient client = new HttpClient();
        public Tabel_Concedii()
        {
            InitializeComponent();
        }

        private async void  GetConcedii()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5085/api/TabelConcedii");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();


            List<Concediu> listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);

            dgvTabelConcedii.ColumnCount = 8;
            dgvTabelConcedii.Columns[0].Name = "Nume";
            dgvTabelConcedii.Columns[1].Name = "Prenume";
            dgvTabelConcedii.Columns[2].Name = "Manager";
            dgvTabelConcedii.Columns[3].Name = "Tip Concediu";
            dgvTabelConcedii.Columns[4].Name = "Inlocuitor";
            dgvTabelConcedii.Columns[5].Name = "Data Inceput";
            dgvTabelConcedii.Columns[6].Name = "Data Final";
            dgvTabelConcedii.Columns[7].Name = "Stare cerere concediu";

            foreach (Concediu c in listaConcedii)
            {
                string[] row = new string[] {c.Angajat.Nume,c.Angajat.Prenume,
                  c.Angajat.Manager.Nume!=null?c.Angajat.Manager.Nume + " "+c.Angajat.Manager.Prenume:"Nu are manager"
                  ,c.TipConcediu.Nume,c.Inlocuitor.Nume+" "+c.Inlocuitor.Prenume,c.DataInceput.ToString("dd/MM/yyyy"),c.DataSfarsit.ToString("dd/MM/yyyy"),c.StareConcediu.Nume};
                  
                int rowIndex = dgvTabelConcedii.Rows.Add(row);
                dgvTabelConcedii.Rows[rowIndex].Tag = c.Id;
         
            }

        }

        private void Tabel_Concedii_Load(object sender, EventArgs e)
        {
            
            Program.EsteAdmin = Convert.ToInt32(SesiuneLogIn.angajatLogat.EsteAdmin);


                if (Program.EsteAdmin == 1)
                {

                      GetConcedii();
               
                }
                else
                {
                    MessageBox.Show("Doar Administratorii pot accesa acest camp");
                }

   

        }
        

        private void dgvTabelConcedii_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdConcediu = this.dgvTabelConcedii.CurrentRow.Tag.ToString();
            PaginaDetalii paginaDetalii = new PaginaDetalii();
            paginaDetalii.Show();
        }
    }
}
