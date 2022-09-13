using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Tabel_Concedii : Form
    {
        private int pagina;
        private int nrPagini;

        static readonly HttpClient client = new HttpClient();
        List<Concediu> listaConcedii = new List<Concediu>();
        List<StareConcediu> listaStariConcedii = new List<StareConcediu>();
        List<TipConcediu> listaTipuriConcedii = new List<TipConcediu>();
        bool dataInceputSelectata = false;
        bool dataFinalSelectata = false;
       
        public Tabel_Concedii(int pagina)
        {
            this.pagina = pagina;
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

        async Task GetNrConcedii(string requestUrl)
        {
            HttpResponseMessage response = await client.GetAsync(requestUrl);
            string responseBody = await response.Content.ReadAsStringAsync();

            int nrConcedii = JsonConvert.DeserializeObject<int>(responseBody);

            if (nrConcedii % 10 == 0)
            {
                nrPagini = nrConcedii / 10;
            }
            else
            {
                nrPagini = nrConcedii / 10 + 1;
            }
        }

        public async Task GetConcedii(string requestUrl)
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
            string URL = String.Format("{0}/TabelConcedii/GetConcediiDupaNumeAngajat?nume={1}&esteAdmin={2}&id={3}", SesiuneLogIn.requestURL, numeAngajat, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id);

            HttpResponseMessage response = await client.GetAsync(URL);
            if (!String.IsNullOrEmpty(numeAngajat))
                response.EnsureSuccessStatusCode();
            string responseBody = "";
            if (response.IsSuccessStatusCode)
                responseBody = await response.Content.ReadAsStringAsync();

            listaConcedii.Clear();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
            if (listaConcedii != null)
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
            // Date Utilizator Logat
            pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizatorLogat.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;

            // Validari Butoane Manager & Admin
            if (SesiuneLogIn.angajatLogat.ManagerId == null || SesiuneLogIn.angajatLogat.EsteAdmin == true)
            {
                buttonDetaliiAngajati.Visible = true;
                buttonPanouAdmin.Visible = true;
            }

            populareComboBox();

            labelPageNumber.Text = Convert.ToString(pagina);

            string URL = String.Format("{0}/TabelConcedii/GetNrConcedii?esteAdmin={1}&id={2}", SesiuneLogIn.requestURL, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id);
            await GetNrConcedii(URL);

            if (pagina != 1)
            {
                buttonPaginaAnterioara.Visible = true;
            }

            if (pagina < nrPagini)
            {
                buttonPaginaUrmatoare.Visible = true;
            }

            int position = (pagina - 1) * 10;
            URL = String.Format("{0}/TabelConcedii/GetConcedii?position={1}&esteAdmin={2}&id={3}", SesiuneLogIn.requestURL, position, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id);

            await GetConcedii(URL);
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

            string URL = String.Format("{0}/TabelConcedii/GetConcediiByStareId?stareId={1}&esteAdmin={2}&id={3}", SesiuneLogIn.requestURL, stareId, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id);

            HttpResponseMessage response = await client.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            listaConcedii = JsonConvert.DeserializeObject<List<Concediu>>(responseBody);
        
        }

        private async Task GetConcediiByTip(int tipId)
        {
            listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("{0}/TabelConcedii/GetConcediiByTipConcediuId?tipConcediuId={1}&esteAdmin={2}&id={3}", SesiuneLogIn.requestURL,tipId, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id));
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
                string URL = String.Format("{0}/TabelConcedii/GetConcedii?&esteAdmin={1}&id={2}", SesiuneLogIn.requestURL, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id);

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
            // listaConcedii.Clear();
            HttpResponseMessage response = await client.GetAsync(String.Format("{0}/TabelConcedii/GetConcediiDupaFiltre?nume={1}&stareId={2}&tipId={3}&dataInceput={4}&dataFinal={5}&esteAdmin={6}&id={7}",SesiuneLogIn.requestURL, nume, stareId,tipId,dataInceput,dataFinal, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id));
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
                await GetConcedii(String.Format("{0}/TabelConcedii/GetConcedii?esteAdmin={1}&id={2}",SesiuneLogIn.requestURL, SesiuneLogIn.angajatLogat.EsteAdmin, SesiuneLogIn.angajatLogat.Id));
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
                dataFinal = dtpDataFinal.Value;
            }
      

            dgvTabelConcedii.Rows.Clear();
        
            await GetConcediiCuFiltre(nume, stareId, tipId, dataInceput, dataFinal);

        
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
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii(pagina);
            formTabelConcedii.Show();
            this.Close();
        }

        private void buttonPaginaUrmatoare_Click(object sender, EventArgs e)
        {
            pagina++;
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii(pagina);
            formTabelConcedii.Show();
            this.Close();
        }
    }
}