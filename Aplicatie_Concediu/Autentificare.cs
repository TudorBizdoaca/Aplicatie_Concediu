using Aplicatie_Concediu;
using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
            pbCaps.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbParola.Text != String.Empty && mail.Text != String.Empty)
            {
                //se decomenteaza in momentul in care pagina register este gata si se inlocuieste la *
                SHA256 sHA256 = SHA256.Create();
                string compara = null;
                compara = tbParola.Text;
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(compara);
                byte[] inputHashedBytes = sHA256.ComputeHash(inputBytes);
                String inputHash = Convert.ToBase64String(inputHashedBytes);
                string result = BitConverter.ToString(inputHashedBytes)
                .Replace("-", string.Empty)
                .ToLower();

                LogInUtilizator(mail.Text, result);
            }
            else
            {
                MessageBox.Show("Inserati valori in ambele campuri");
            }
        }

        private async void LogInUtilizator(string email, string parola)
        {
            string URL = String.Format("{0}/Autentificare/LogInUtilizator?email={1}&parola={2}", SesiuneLogIn.requestURL, email, parola);

            // Creare conexiune
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            Angajat angajatLogat = JsonConvert.DeserializeObject<Angajat>(responseBody);
            if (angajatLogat != null)
            {
                SesiuneLogIn.angajatLogat = angajatLogat;
                PaginaMea paginaMea = new PaginaMea();
                paginaMea.Show();
                this.Hide();
            }
            else
            {
                SesiuneLogIn.angajatLogat = null;
                MessageBox.Show("Email sau parola gresita");
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
                tbParola.Focus();
                e.Handled = true;
            }
        }
        
        private void tbParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                pbCaps.Show();
            else
                pbCaps.Hide();
        }

        private void tbParola_Click(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                pbCaps.Show();
            else
                pbCaps.Hide();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            Application.Exit();
        }
    }
}