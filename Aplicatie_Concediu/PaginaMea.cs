﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class PaginaMea : Form
    {
        public PaginaMea()
        {
            InitializeComponent();
        }

        private void PaginaMea_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Angajat where id = " + Autentificare.UserId);
            SqlDataReader dr = command.ExecuteReader();
        }

        private void buttonEditeazaProfil_Click(object sender, EventArgs e)
        {

        }
    }
}
