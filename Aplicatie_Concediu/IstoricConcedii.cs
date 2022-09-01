using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string selectQuery = "select t.nume as [Tip Concediu], dataInceput, dataSfarsit, concat(a.nume,a.prenume) as Inlocuitor,sc.nume as [Stare Concediu]\r\nfrom Concediu c \r\njoin TipConcediu t on c.tipConcediuId = t.id\r\njoin StareConcediu sc on  c.stareConcediuId = sc.id\r\njoin Angajat a on c.inlocuitorId = a.id\r\nwhere angajatId = @id";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaMea paginaMea = new PaginaMea();
            paginaMea.Show();
        }
    }
}
