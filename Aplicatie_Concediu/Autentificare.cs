using Aplicatie_Concediu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            cn.Open();
            if (parola.Text != String.Empty && mail.Text != String.Empty)
            {
                //SHA256 sHA256 = SHA256.Create();
                //string compara = null;
                //compara = parola.Text;
                //byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(compara);
                //byte[] inputHashedBytes = sHA256.ComputeHash(inputBytes);
                //String inputHash = Convert.ToBase64String(inputHashedBytes);
                //string result = BitConverter.ToString(inputHashedBytes)
                //.Replace("-", string.Empty)
                //.ToLower();

                SqlCommand cmd = new SqlCommand("select * from Angajat where  email='" + mail.Text + "' and parola= '" + parola.Text + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    PaginaMea paginaMea = new PaginaMea();
                    paginaMea.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("E-mail sau parola gresita");
                }
            
            }
            else
            {
                MessageBox.Show("Inserati valori in ambele campuri");
            }
        }
    }
}

