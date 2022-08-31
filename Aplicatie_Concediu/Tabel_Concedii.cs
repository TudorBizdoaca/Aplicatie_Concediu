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
    public partial class Tabel_Concedii : Form
    {
        public Tabel_Concedii()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Tabel_Concedii_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select a.nume, a.prenume, concat(a2.Nume,' ', a2.Prenume) as Manager,t.nume as \"Tip Concediu\",  c.dataInceput, c.dataSfarsit ,concat(a3.Nume,' ', a3.Prenume) as inlocuitor , s.nume as \"Stare Concediu\"\r\nfrom Angajat a\r\njoin Concediu c on c.angajatId = a.id\r\njoin StareConcediu s on s.id = c.stareConcediuId\r\njoin TipConcediu t on t.id = c.tipConcediuId\r\njoin Angajat a2 on a2.Id = a.ManagerId\r\njoin Angajat a3 on a3.Id = c.InlocuitorId", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dataGridView1.DataSource = table;
        }
    }
}
