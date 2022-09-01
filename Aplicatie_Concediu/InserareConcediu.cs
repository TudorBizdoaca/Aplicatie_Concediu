using System;
using System.Collections;
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
    public partial class InserareConcediu : Form
    { DateTime StartDate;
        DateTime EndDate;
        SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");

        public void cbTipConcediuLoad()
        {
            string query = "select nume from TipConcediu";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                
                cbTipConcediu.Items.Add(dataReader[0]);
            }
            dataReader.Close();
        }
        public void cbInlocuitorLoad()
        {
            string query = "select CONCAT(a.id,' ',nume,' ',prenume) from angajat a\r\njoin ( SELECT angajatId FROM Concediu\r\nWHERE  (dataInceput <= @endDate) AND (dataSfarsit >= @startDate ) ) subs on subs.angajatId != a.id; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@startDate", StartDate));
            command.Parameters.Add(new SqlParameter("@endDate", EndDate));
            SqlDataReader dataReader = command.ExecuteReader();
           command = new SqlCommand(query, connection);
            
            while (dataReader.Read())
            {
                
               cbInlocuitor.Items.Add(dataReader[0]);
            }
            dataReader.Close();
        }
        public InserareConcediu()
        {
            InitializeComponent();
 
            connection.Open();

            cbTipConcediuLoad();
           
        }

        private void InserareConcediu_Load(object sender, EventArgs e)
        {
           

        }

    

        private void dtpInceputConcediu_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpInceputConcediu.Value;
        }

        private void dtpFinalConcediu_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpFinalConcediu.Value;
            cbInlocuitorLoad();
        }
    }
}
