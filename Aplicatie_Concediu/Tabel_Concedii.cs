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


        private void Tabel_Concedii_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            cn.Open();
            
            SqlCommand cmd = new SqlCommand("select c.id as [Id Concediu], a.nume as Nume, a.prenume as Prenume, concat(a2.Nume,' ', a2.Prenume) as Manager,t.nume as \"Tip Concediu\",concat(a3.Nume,' ', a3.Prenume) as Inlocuitor,  c.dataInceput as [Data Inceput], c.dataSfarsit as [Data Final]  , s.nume as \"Stare Cerere Concediu\"\r\nfrom Angajat a\r\njoin Concediu c on c.angajatId = a.id\r\njoin StareConcediu s on s.id = c.stareConcediuId\r\njoin TipConcediu t on t.id = c.tipConcediuId\r\njoin Angajat a2 on a2.Id = a.ManagerId\r\njoin Angajat a3 on a3.Id = c.InlocuitorId\r\n", cn);
           
            SqlDataReader dr = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(dr);
            dgvTabelConcedii.DataSource = table;


        }

        private void dgvTabelConcedii_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.IdConcediu = this.dgvTabelConcedii.CurrentRow.Cells[0].Value.ToString();
            PaginaDetalii paginaDetalii = new PaginaDetalii();
            paginaDetalii.Show();
        }
    }
}
