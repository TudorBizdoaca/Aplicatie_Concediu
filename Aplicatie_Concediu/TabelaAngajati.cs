﻿using System;
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
    public partial class TabelaAngajati : Form
    {       
       
       
        public TabelaAngajati()
        {
            DataTable dtAngajati = new DataTable();
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();
            string query = "select a.poza,a.nume, a.prenume,a.email, a.dataAngajare, a.dataNasterii, a.cnp, a.serie, a.no, a.nrTelefon,a.esteAdmin, case when a.managerId IS NOT NULL then CONCAT(m.nume,' ',m.prenume) else 'No Manager' end as Manager, a.ZileConcediu from Angajat a\r\nleft join (select nume,prenume,id\r\nfrom Angajat ) m on m.id = a.managerId;\r\n";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            dtAngajati.Load(reader);
            dgvAngajati.DataSource = dtAngajati;
            
            connection.Close();
        }

       
    }
}