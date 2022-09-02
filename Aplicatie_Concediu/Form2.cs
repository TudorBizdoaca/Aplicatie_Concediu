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
    public partial class PaginaDetalii : Form
    {
        public PaginaDetalii()
        {
            InitializeComponent();
        }

        private void PaginaDetalii_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            cn.Open();
            IdConcediu.Text = Program.IdConcediu;
            SqlCommand cmd = new SqlCommand("select c.id as [Id Concediu], concat(a.Nume,' ', a.Prenume) as Nume, concat(a2.Nume,' ', a2.Prenume) as Manager,t.nume as \"Tip Concediu\",concat(a3.Nume,' ', a3.Prenume) as Inlocuitor,  c.dataInceput as [Data Inceput], c.dataSfarsit as [Data Final]  , s.nume as \"Stare Cerere Concediu\", c.comentarii as [Comentariu]\r\nfrom Angajat a\r\njoin Concediu c on c.angajatId = a.id\r\njoin StareConcediu s on s.id = c.stareConcediuId\r\njoin TipConcediu t on t.id = c.tipConcediuId\r\njoin Angajat a2 on a2.Id = a.ManagerId\r\njoin Angajat a3 on a3.Id = c.InlocuitorId\r\nwhere c.id = " + Program.IdConcediu);
            cmd.Connection = cn;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Nume.Text = Convert.ToString(dr["Nume"]);
                Manager.Text = Convert.ToString(dr["Manager"]);
                TipConcediu.Text = Convert.ToString(dr["Tip Concediu"]);
                Inlocuitor.Text = Convert.ToString(dr["Inlocuitor"]);
                DataInceput.Text = Convert.ToString(dr["Data Inceput"]);
                DataFinal.Text = Convert.ToString(dr["Data Final"]);
                StareCerereConcediu.Text = Convert.ToString(dr["Stare Cerere Concediu"]);
                Comentariu.Text = Convert.ToString(dr["Comentariu"]);
            }
            dr.Close();
            cn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
