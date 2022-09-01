using Aplicatie_Concediu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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


                //se decomenteaza in momentul in care pagina register este gata si se inlocuieste la *
                SHA256 sHA256 = SHA256.Create();
                string compara = null;
                compara = parola.Text;
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(compara);
                byte[] inputHashedBytes = sHA256.ComputeHash(inputBytes);
                String inputHash = Convert.ToBase64String(inputHashedBytes);
                string result = BitConverter.ToString(inputHashedBytes)
                .Replace("-", string.Empty)
                .ToLower();


                //* se inlocuieste parola.Text cu result
                SqlCommand cmd = new SqlCommand("select * from Angajat where  email='" + mail.Text + "' and parola= '" + result + "'", cn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Program.UserId = int.Parse(dr["id"].ToString());
                    dr.Close();
                    this.Hide();
                    PaginaMea paginaMea = new PaginaMea();
                    paginaMea.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Email sau parola gresita");
                }

            }
            else
            {
                MessageBox.Show("Inserati valori in ambele campuri");
            }
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Inregistrare inregistrare = new Inregistrare();
            inregistrare.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ResetareParola resetare = new ResetareParola();
            resetare.Show();
        }

        private void parola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(sender, e);
                e.Handled = true;
            }


        }

        private void mail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                parola.Focus();
                e.Handled = true;


            }
        }
    }
}