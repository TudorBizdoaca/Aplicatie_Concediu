﻿using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            foreach (Concediu c in concedii)
            {
                string[] row = new string[] {c.Angajat.Nume,c.Angajat.Prenume,
                  c.Angajat.Manager.Nume!=null?c.Angajat.Manager.Nume + " "+c.Angajat.Manager.Prenume:"Nu are manager"
                  ,c.TipConcediu.Nume,c.Inlocuitor.Nume+" "+c.Inlocuitor.Prenume,c.DataInceput.ToString("dd/MM/yyyy"),c.DataSfarsit.ToString("dd/MM/yyyy"),c.StareConcediu.Nume};

                int rowIndex = dgvTabelConcedii.Rows.Add(row);
                dgvTabelConcedii.Rows[rowIndex].Tag = c.Id;
            }

        }
       
        private async Task GetConcedii(string requestUrl)
        {
            HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            listaConcedii.Clear();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
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
         
            cbStariConcedii.ValueMember ="Id";
            cbStariConcedii.DisplayMember = "Nume";
            sToate.Id = 0;
            sToate.Nume = "Toate";
            listaStariConcedii.Add(sToate);
            cbStariConcedii.SelectedValue = sToate.Id.ToString();
            cbStariConcedii.DataSource = listaStariConcedii;
        
            cbStariConcedii.SelectedIndex = cbStariConcedii.Items.Count-1;
        }
        private async void Tabel_Concedii_Load(object sender, EventArgs e)
        {
            // Date Utilizator Logat
            pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizatorLogat.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;

            // Validari Butoane Manager
            if (SesiuneLogIn.angajatLogat.ManagerId == null)
            {
                buttonDetaliiAngajati.Visible = true;
            }

            // Validari Butoane Admini
            if (SesiuneLogIn.angajatLogat.EsteAdmin == true)
            {
                buttonDetaliiAngajati.Visible = true;
                buttonPanouAdmin.Visible = true;
            }

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
            PaginaDetalii paginaDetalii = new PaginaDetalii();
            paginaDetalii.Show();
        }
        private async Task GetConcediiByStare(int stareId)
        {
            listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("http://localhost:5085/api/TabelConcedii/GetConcediiByStareId?stareId={0}",stareId));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        }

        private async void repopulareGV()
        {
            dgvTabelConcedii.Rows.Clear();
            await GetConcediiByStare((int)cbStariConcedii.SelectedValue);
            populareGridView(listaConcedii);
        }
       
        private async void cbStariConcedii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbStariConcedii.SelectedValue.ToString() !="0")
                 repopulareGV();
            else
            {
                await GetConcedii("http://localhost:5085/api/TabelConcedii/GetConcedii");
                listaConcedii.Clear();
                populareGridView(listaConcedii);
            }
        }

        // Buton Iesire
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            Application.Exit();
        }

        // Click Utilizator Logat
        private void pictureBoxUtilizatorLogat_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void labelNumeUtilizatorLogat_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        // Buton Deconectare
        private void labelDeconectare_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            Autentificare formAutentificare = new Autentificare();
            formAutentificare.Show();
            this.Close();
        }

        // Butoane Meniu
        private void buttonPaginaMea_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void buttonCerereConcediu_Click(object sender, EventArgs e)
        {
            InserareConcediu formInserareConcediu = new InserareConcediu();
            formInserareConcediu.Show();
            this.Close();
        }

        private void buttonIstoricConcedii_Click(object sender, EventArgs e)
        {
            IstoricConcedii formIstoricConcedii = new IstoricConcedii();
            formIstoricConcedii.Show();
            this.Close();
        }

        private void buttonDetaliiAngajati_Click(object sender, EventArgs e)
        {
            TabelaAngajati formTabelaAngajati = new TabelaAngajati();
            formTabelaAngajati.Show();
            this.Close();
        }

        private void buttonPanouAdmin_Click(object sender, EventArgs e)
        {
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii();
            formTabelConcedii.Show();
            this.Close();
        }
    }
}
