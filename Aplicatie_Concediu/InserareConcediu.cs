using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class InserareConcediu : Form
    {
        const int CONCEDIU_IN_ASTEPTARE = 2;
        DateTime StartDate;
        DateTime EndDate;

        static readonly HttpClient client = new HttpClient();
        public List<TipConcediu> TipuriConcediu = new List<TipConcediu>();
        public List<Concediu> Concedii = new List<Concediu>();
        public List<Angajat> Angajati = new List<Angajat>();
        List<int> ListaIduriInConcediu = new List<int>();

        Dictionary<int, int> zileConcediuPerTip = new Dictionary<int, int>();
        public async Task getAngajati()
        {
            HttpResponseMessage response = await client.GetAsync("");
            string responseBody = await response.Content.ReadAsStringAsync();
            Angajati = JsonConvert.DeserializeObject<List<Angajat>>(responseBody);
        }
        public async Task getTipuriConcediu()
        {
            HttpResponseMessage response = await client.GetAsync("");
            string responseBody = await response.Content.ReadAsStringAsync();
            TipuriConcediu = JsonConvert.DeserializeObject<List<TipConcediu>>(responseBody);

        }
        public async Task cbTipConcediuLoadAsync()
        {

            HttpResponseMessage response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/getTipuriConcediu");
            string responseBody = await response.Content.ReadAsStringAsync();
            TipuriConcediu = JsonConvert.DeserializeObject<List<TipConcediu>>(responseBody);
            cbTipConcediu.DataSource = TipuriConcediu;
            cbTipConcediu.DisplayMember = "Nume";
            cbTipConcediu.ValueMember = "Id";
        }
        public async void cbInlocuitorLoad()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/getAngajati?Id=" + SesiuneLogIn.angajatLogat.Id.ToString());
            string responseBody = await response.Content.ReadAsStringAsync();
            Angajati = JsonConvert.DeserializeObject<List<Angajat>>(responseBody);
            cbInlocuitor.DataSource = Angajati;
            cbInlocuitor.DisplayMember = "Nume";
            cbInlocuitor.ValueMember = "Id";


        }
        public InserareConcediu()
        {
            InitializeComponent();


            cbTipConcediuLoadAsync();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;


        }

        private async void InserareConcediu_LoadAsync(object sender, EventArgs e)
        {
            cbInlocuitorLoad();
            await cbTipConcediuLoadAsync();

            // Date Utilizator Logat
            pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizatorLogat.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;
            var response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/getZileConcediu?idAngajat=" + SesiuneLogIn.angajatLogat.Id.ToString());
            string responseBody = await response.Content.ReadAsStringAsync();
            zileConcediuPerTip = JsonConvert.DeserializeObject<Dictionary<int, int>>(responseBody);
            lblZileConcediu.Text = zileConcediuPerTip[(int)cbTipConcediu.SelectedValue].ToString();
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
        }



        private void dtpInceputConcediu_ValueChanged(object sender, EventArgs e)
        {

            cbInlocuitorLoad();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;


        }

        private void dtpFinalConcediu_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpInceputConcediu.Value;
            EndDate = dtpFinalConcediu.Value;

            cbInlocuitorLoad();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;

        }
        public async Task insertConcediuAsync()
        {

            //fa check inainte de inlocuitor id

            Concediu c = new Concediu();
            c.TipConcediuId = int.Parse(cbTipConcediu.SelectedValue.ToString());
            c.DataInceput = StartDate;
            c.DataSfarsit = EndDate;
            c.AngajatId = SesiuneLogIn.angajatLogat.Id;
            c.Comentarii = rtfComentarii.Text;
            c.InlocuitorId = int.Parse(cbInlocuitor.SelectedValue.ToString());
            c.StareConcediuId = CONCEDIU_IN_ASTEPTARE;
            HttpResponseMessage response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/esteAngajatInConcediu?id=" + int.Parse(cbInlocuitor.SelectedValue.ToString()) + "&dataInceput=" + StartDate.ToString() + "&dataFinal=" + EndDate.ToString());
            string responseBody = await response.Content.ReadAsStringAsync();
            bool esteInlocuitorulInConcediu = bool.Parse(responseBody);
            if (esteInlocuitorulInConcediu == true)
            {
                DialogResult dr = MessageBox.Show("Inlocuitorul este in concediu pe perioada selectata,\n " +
                    "esti sigura ca doresti sa faci asta?", "Avertisment",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr.Equals(DialogResult.No))
                {
                    return;
                }
            }

            var content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
            client.PostAsync("http://localhost:5085/api/InserareConcediu/insertConcediu", content);
            MessageBox.Show("Concediu inserat cu succes");

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

        // Butoane Pagina
        private async void button1_Click(object sender, EventArgs e)
        {
            StartDate = dtpInceputConcediu.Value;
            EndDate = dtpFinalConcediu.Value;
            if (cbTipConcediu.SelectedItem == null)
            {
                MessageBox.Show("Alege tipul de concediu!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DateCalculator.bussinessDaysBetween(StartDate, EndDate) > int.Parse(lblZileConcediu.Text))
            {
                MessageBox.Show("Actiune imposibila, concediul cerut este prea lung", "Concediu Prea Lung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/getZileConcediu?idAngajat=" + SesiuneLogIn.angajatLogat.Id.ToString());
            string responseBody = await response.Content.ReadAsStringAsync();
            zileConcediuPerTip = JsonConvert.DeserializeObject<Dictionary<int, int>>(responseBody);
            response = await client.GetAsync("http://localhost:5085/api/InserareConcediu/esteAngajatInConcediu?id=" + SesiuneLogIn.angajatLogat.Id.ToString() + "&dataInceput=" + StartDate.ToString() + "&dataFinal=" + EndDate.ToString());
            responseBody = await response.Content.ReadAsStringAsync();
            bool esteAngajatulInConcediu = bool.Parse(responseBody);
            if (esteAngajatulInConcediu == true)
            {
                MessageBox.Show("Actiune imposibila, deja aveti o cerere de concediu pentru perioada selectata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await insertConcediuAsync();
            buttonIstoricConcedii_Click(sender, e);

        }

        private void rtfComentarii_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblCharCount.Text = "Caractere ramase: " + (500 - (rtfComentarii.Text.Length)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbTipConcediu_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int index = ((TipConcediu)cbTipConcediu.SelectedItem).Id - 1;
            //lblZileConcediu.Text = zileConcediuPerTip[index].ToString();
        }

        private void cbTipConcediu_SelectedValueChanged(object sender, EventArgs e)
        {

            //int index = ((TipConcediu)cbTipConcediu.SelectedItem).Id - 1;
            //lblZileConcediu.Text = zileConcediuPerTip[index].ToString();
        }

        private void cbTipConcediu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = ((TipConcediu)cbTipConcediu.SelectedItem).Id;
            lblZileConcediu.Text = zileConcediuPerTip[index].ToString();
        }
    }
}
