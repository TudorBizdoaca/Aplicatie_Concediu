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
    public partial class dgvTabelaAngajati : Form
    {       
       
       
        public dgvTabelaAngajati()
        {
            DataTable dtAngajati = new DataTable();
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();
            string query = "select * from Angajat";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            dtAngajati.Load(reader);
            dgvAngajati.DataSource = dtAngajati;
        }

       
    }
}
