using Aplicatie_Concediu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class IstoricConcedii : Form
    {
        public  List<CardConcediu> CarduriConcediu = new List<CardConcediu>();
        static readonly HttpClient client = new HttpClient();
        List<Concediu> concedii = new List<Concediu>();
        public IstoricConcedii()
        {
            InitializeComponent();
           
        }
        public async Task getConcediiAsync()
        {
            HttpResponseMessage response = await client.GetAsync(String.Format("http://localhost:5085/api/IstoricConcedii/GetConcediiAngajat?Id={0}", Utils.SesiuneLogIn.angajatLogat.Id));
            string responseBody = await response.Content.ReadAsStringAsync();
            concedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
            foreach (Concediu c in concedii)
            {
              CarduriConcediu.Add(new CardConcediu(c));
            }

        }
     
     
        // Buton Iesire
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Utilizator Logat
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

        private void labelDeconectare_Click(object sender, EventArgs e)
        {
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

        private async void IstoricConcedii_Load(object sender, EventArgs e)
        {
            int counter = 0;
            int position = 0;
           
            await getConcediiAsync();
            foreach(CardConcediu c in CarduriConcediu)
            {
                c.Parent = pnlCarduri;
                c.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                if (counter == 0)
                {
                    position = c.Location.Y;
                }
                else
                {
                    position += 400;
                    c.Location = new System.Drawing.Point(c.Location.X, position);
                }
                counter++;
            }
        }
    }
}
