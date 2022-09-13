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
        private int pagina;
        private int nrPagini;

        const string ImagePath = "C:\\Users\\gunal.sadic\\Downloads\\PozaDefaultAngajati";
        static readonly HttpClient client = new HttpClient();
        public  TabelaAngajati(int pagina)
        {
            this.pagina = pagina;
            InitializeComponent();
        }
        List<Angajat> Angajati = new List<Angajat>();

        async Task GetNrAngajati()
        {
            string URL = String.Format("{0}/Angajat/GetNrAngajati?id={1}&esteAdmin={2}", SesiuneLogIn.requestURL,SesiuneLogIn.angajatLogat.Id,SesiuneLogIn.angajatLogat.EsteAdmin);

            HttpResponseMessage response = await client.GetAsync(URL);
            string responseBody = await response.Content.ReadAsStringAsync();

            int nrAngajati = JsonConvert.DeserializeObject<int>(responseBody);

            if (nrAngajati % 15 == 0)
            {
                nrPagini = nrAngajati / 15;
            }
            else
            {
                nrPagini = nrAngajati / 15 + 1;
            }
        }

        async Task GetAngajati()
        {
          
                int position = (pagina - 1) * 15;

                string URL = String.Format("{0}/Angajat/GetAngajati?position={1}&id={2}&esteAdmin={3}", SesiuneLogIn.requestURL, position, SesiuneLogIn.angajatLogat.Id, SesiuneLogIn.angajatLogat.EsteAdmin);

                HttpResponseMessage response = await client.GetAsync(URL);
                string responseBody = await response.Content.ReadAsStringAsync();
                Angajati = JsonConvert.DeserializeObject<List<Angajat>>(responseBody);
                var source = new BindingSource();
                source.DataSource = Angajati;
                dgvAngajati.DataSource = source;
            if (dgvAngajati.Columns.Count != 0)
            {
                dgvAngajati.Columns.Remove("Manager");
                dgvAngajati.Columns.Remove("ConcediuAngajats");
                dgvAngajati.Columns.Remove("ConcediuInlocuitors");
                dgvAngajati.Columns.Remove("InverseManager");
            }
          
        }

        private async void TabelaAngajati_Load(object sender, EventArgs e)
        {
            // Date Utilizator Logat
            pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizatorLogat.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;

            // Validari Butoane Manager & Admin
            if (SesiuneLogIn.angajatLogat.ManagerId == null || SesiuneLogIn.angajatLogat.EsteAdmin == true)
            {
                buttonDetaliiAngajati.Visible = true;
                buttonPanouAdmin.Visible = true;
            }

            labelPageNumber.Text = Convert.ToString(pagina);

            await GetNrAngajati();

            if (pagina != 1)
            {
                buttonPaginaAnterioara.Visible = true;
            }

            if (pagina < nrPagini)
            {
                buttonPaginaUrmatoare.Visible = true;
            }

            await GetAngajati();
           
        }

        // Buton Iesire
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            client.Dispose();
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
            TabelaAngajati formTabelaAngajati = new TabelaAngajati(1);
            formTabelaAngajati.Show();
            this.Close();
        }

        private void buttonPanouAdmin_Click(object sender, EventArgs e)
        {
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii(1);
            formTabelConcedii.Show();
            this.Close();
        }

        private void buttonPaginaAnterioara_Click(object sender, EventArgs e)
        {
            pagina--;
            TabelaAngajati formTabelaAngajati = new TabelaAngajati(pagina);
            formTabelaAngajati.Show();
            this.Close();
        }

        private void buttonPaginaUrmatoare_Click(object sender, EventArgs e)
        {
            pagina++;
            TabelaAngajati formTabelaAngajati = new TabelaAngajati(pagina);
            formTabelaAngajati.Show();
            this.Close();
        }
    }
}
