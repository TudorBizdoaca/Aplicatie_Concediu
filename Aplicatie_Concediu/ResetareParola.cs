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

namespace Aplicatie_Concediu
{
    public partial class ResetareParola : Form
    {
        string codVerificareTrimis;
        public ResetareParola()
        {
            InitializeComponent();
            tbParola.Enabled = false;
            tbConfirmaParola.Enabled = false;
        }
        private string generareCodVerificare()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();

        }
        private string criptareParola(string parola)
        {
            SHA256 sHA256 = SHA256.Create();
            string compara = null;
            compara = parola;
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(compara);
            byte[] inputHashedBytes = sHA256.ComputeHash(inputBytes);
            String inputHash = Convert.ToBase64String(inputHashedBytes);
            string result = BitConverter.ToString(inputHashedBytes)
            .Replace("-", string.Empty)
            .ToLower();
            return result;
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
            smtpClient.Send(mail);
            MessageBox.Show("Cod de verificare trimis pe e-mail", "Cod de verificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return codVerificare;
        }

        private void btnTrimiteCodVerificare_Click(object sender, EventArgs e)
        {
            codVerificareTrimis = trimiteCodVerificare();
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
            string confirmaParola = tbParola.Text;
           
            if (parolaIntrodusa == confirmaParola)
            {
                string connectionString = "Data Source=ts2112\\SQLEXPRESS;Initial Catalog=BreakingBread;User ID=internship2022;Password=int";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string updateQuery = "update Angajat set parola=@parola where email=@email";
                SqlParameter pParola = new SqlParameter("@parola", System.Data.SqlDbType.NVarChar, 100);
                pParola.Value = criptareParola(tbParola.Text);
                SqlParameter pEmail = new SqlParameter("@email", System.Data.SqlDbType.NVarChar, 50);
                pEmail.Value = tbEmail.Text;
                SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                updateCommand.Parameters.Add(pParola);
                updateCommand.Parameters.Add(pEmail);
                sqlConnection.Open();
                int n =  updateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (n > 0)
                {
                    MessageBox.Show("Parola resetata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Autentificare autentificare = new Autentificare();
                    autentificare.Show();
                }
                else
                {
                    MessageBox.Show("Resetare parola esuata!!", "Esec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Parolele nu se potrivesc!","Eroare parola",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
