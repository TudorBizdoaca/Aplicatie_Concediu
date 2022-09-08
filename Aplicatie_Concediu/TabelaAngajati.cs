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
using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;

namespace Aplicatie_Concediu
{
    
    public partial class TabelaAngajati : Form
    {
        const string ImagePath = "C:\\Users\\gunal.sadic\\Downloads\\PozaDefaultAngajati";
        static readonly HttpClient client = new HttpClient();
        public  TabelaAngajati()
        {
            
            InitializeComponent();
        }
        List<Angajat> Angajati = new List<Angajat>();
        async Task GetAngajati()
        {
        
            HttpResponseMessage response =  await client.GetAsync("http://localhost:5085/api/Angajat/GetAngajati");
            string responseBody = await response.Content.ReadAsStringAsync();
            Angajati = JsonConvert.DeserializeObject<List<Angajat>>(responseBody);
            var source = new BindingSource();
            source.DataSource = Angajati;
            dgvAngajati.DataSource = source;
            dgvAngajati.Columns.Remove("Manager");
            dgvAngajati.Columns.Remove("ConcediuAngajats");
            dgvAngajati.Columns.Remove("ConcediuInlocuitors");
            dgvAngajati.Columns.Remove("InverseManager");
            
           
        }

        private void TabelaAngajati_Load(object sender, EventArgs e)
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

            GetAngajati();
           
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
