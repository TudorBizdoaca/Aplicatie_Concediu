using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class IstoricConcedii : Form
    {
        public IstoricConcedii()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();
            string selectQuery = "select t.nume as [Tip Concediu], dataInceput, dataSfarsit, concat(a.nume,'',a.prenume) as Inlocuitor,sc.nume as [Stare Concediu]\r\nfrom Concediu c \r\njoin TipConcediu t on c.tipConcediuId = t.id\r\njoin StareConcediu sc on  c.stareConcediuId = sc.id\r\njoin Angajat a on c.inlocuitorId = a.id\r\nwhere angajatId = @id";
            SqlCommand comm = new SqlCommand(selectQuery,connection);
            SqlParameter pId = new SqlParameter("@id",SqlDbType.Int);
            pId.Value = Program.UserId;
            comm.Parameters.Add(pId);
            DataTable dtIstoricConcedii = new DataTable();
            SqlDataReader dr = comm.ExecuteReader();
            dtIstoricConcedii.Load(dr);
            dgvIstoricConcedii.DataSource = dtIstoricConcedii;
            connection.Close();
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
    }
}
