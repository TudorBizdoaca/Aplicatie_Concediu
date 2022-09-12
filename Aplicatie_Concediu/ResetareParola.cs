using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Http;
using Newtonsoft.Json;
using Aplicatie_Concediu.Utils;

namespace Aplicatie_Concediu
{
    public partial class ResetareParola : Form
    {
        string codVerificareTrimis;
        static readonly HttpClient client = new HttpClient();
        public ResetareParola()
        {
            InitializeComponent();
            tbParola.Enabled = false;
            tbConfirmaParola.Enabled = false;
        }

        private async void ReseteazaParola(string email, string parola)
        {
            string URL = String.Format("{0}/ResetareParola?email={1}&parola={2}", SesiuneLogIn.requestURL, email, parola);

            HttpResponseMessage response = await client.PostAsync(URL, new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("", "") }));
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Parola resetata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Autentificare autentificare = new Autentificare();
                autentificare.Show();
            } else
            {
                MessageBox.Show("Resetare parola esuata!!", "Esec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private string generareCodVerificare()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();

        }
    
        private string trimiteCodVerificare()
        {
            string codVerificare = generareCodVerificare();
            string mesaj = "Codul tau de verificare este: " + codVerificare;
            MailMessage mail = new MailMessage("madalina.mireag@totalsoft.ro", tbEmail.Text, "Cod Verificare Email", mesaj);
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "mailer14.totalsoft.local";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("madalina.mireag@totalsoft.ro", "Skillet19");
          
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Trimitere esuata!!", "Esec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            MessageBox.Show("Cod de verificare trimis pe e-mail", "Cod de verificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return codVerificare;
        }
     
        private void btnTrimiteCodVerificare_Click(object sender, EventArgs e)
        {
            try
            {
                codVerificareTrimis = trimiteCodVerificare();
            }
            catch (Exception)
            {
                if (tbEmail.Text == String.Empty || tbEmail.Text == null)
                    MessageBox.Show("Introdu adresa de email!");
                else
                MessageBox.Show("Adresa de email invalida");
            }
        }

        private void tbCodVerificare_TextChanged(object sender, EventArgs e)
        {
            if(tbCodVerificare.Text == codVerificareTrimis)
            {
                tbConfirmaParola.Enabled = true;
                tbParola.Enabled = true;
            }
        }

        private void btnResetareParola_Click(object sender, EventArgs e)
        {
            string parolaIntrodusa = tbParola.Text;
            string confirmaParola = tbConfirmaParola.Text;
           
            if (parolaIntrodusa == confirmaParola)
            {
                parolaIntrodusa = Program.criptareParola(parolaIntrodusa);
                ReseteazaParola(tbEmail.Text, parolaIntrodusa);

            }
            else
            {
                MessageBox.Show("Parolele nu se potrivesc!","Eroare parola",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareParola(errorProviderParola, tbParola);
        }

        private void tbConfirmaParola_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareParola(errorProviderConfirmaParola, tbConfirmaParola);
        }

        private void tbParola_Validated(object sender, EventArgs e)
        {
            errorProviderParola.Clear();
        }

        private void tbConfirmaParola_Validated(object sender, EventArgs e)
        {
            errorProviderConfirmaParola.Clear();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            Application.Exit();
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            Autentificare formAutentificare = new Autentificare();
            formAutentificare.Show();
            this.Close();
        }
    }
}
