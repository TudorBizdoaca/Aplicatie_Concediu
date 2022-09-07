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
     
            HttpResponseMessage response = await client.PostAsync(String.Format("http://localhost:5085/api/ResetareParola?email={0}&parola={1}",email,parola),new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("", "") }));
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
            Program.validareParola(errorProviderParola, tbParola);
        }

        private void tbConfirmaParola_TextChanged(object sender, EventArgs e)
        {
            Program.validareParola(errorProviderConfirmaParola, tbConfirmaParola);
        }

        private void tbParola_Validated(object sender, EventArgs e)
        {
            errorProviderParola.Clear();
        }

        private void tbConfirmaParola_Validated(object sender, EventArgs e)
        {
            errorProviderConfirmaParola.Clear();
        }
    }
}
