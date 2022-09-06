using Aplicatie_Concediu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Inregistrare : Form
    {
        string codVerificareTrimis;
     
       public Inregistrare()
        {
            InitializeComponent();

        }
        
        public bool InrengistrareAngajatAPI (Angajat ang)
        {
            var requestBody = JsonConvert.SerializeObject(ang);
            var requestData = Encoding.UTF8.GetBytes(requestBody);
            string URL = "http://localhost:5085/PaginaInregistrare/InsertAngajat";
            HttpWebRequest httpWebRequest =(HttpWebRequest) HttpWebRequest.Create(new Uri(URL));
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.ContentLength = requestData.Length;
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(requestData, 0, requestData.Length);
            }
            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;

            }
            else return false;
        }
        Angajat ang = new Angajat();
        
       private void btnInregistrare_Click(object sender, EventArgs e)
        {
            
            string codVerificareIntrodus = tbCodVerificare.Text;
            Angajat ang = new Angajat();
            if (validareFormular() && codVerificareIntrodus == codVerificareTrimis)
            {
                
                ang.Nume = tbInregistrareNume.Text;
                ang.Prenume = tbPrenume.Text;
                ang.Email = tbEmail.Text;
                ang.Parola = Program.criptareParola(tbParola.Text);
                ang.DataNasterii = dtpDataNastere.Value;
                ang.DataAngajare = dtpDataAngajare.Value;
                ang.Cnp = tbCnp.Text;
                ang.Serie = tbSerieBuletin.Text;
                ang.No = tbNrBuletin.Text;
                ang.NrTelefon = tbNrTelefon.Text;
              
                bool d = InrengistrareAngajatAPI(ang);
                if (d == true)
                {
                    MessageBox.Show("Angajat inserat cu succes!", "Succes Inserare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Autentificare autentificare = new Autentificare();
                    autentificare.Show();
                } else
                {
                    MessageBox.Show("Inserarea a esuat!", "Eroare Inserare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


           } else
            {
              MessageBox.Show("Formularul contine erori!","Erori validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Permit Introducere doar de cifre
        private void tbCnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void tbNrTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) != true)
            {
                e.Handled = true;
            } 
        }

        private void tbNrBuletin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        #endregion



        #region Validare Campuri

        private void tbInregistrareNume_TextChanged(object sender, EventArgs e)
        {
            Program.validareNume(errorProviderNume, tbInregistrareNume);
        }

        private void tbPrenume_TextChanged(object sender, EventArgs e)
        {
            Program.validarePrenume(errorProviderPrenume, tbPrenume);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            Program.validareEmail(errorProviderEmail, tbEmail);
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            Program.validareParola(errorProviderParola, tbParola);
        }

        private void tbParolaConfirmare_TextChanged(object sender, EventArgs e)
        {
            Program.validareConfirmaParola(errorProviderConfirmaParola, tbParolaConfirmare, tbParola.Text);
        }

        private void tbSerieBuletin_TextChanged(object sender, EventArgs e)
        {
            Program.validareSerie(errorProviderSerieBuletin, tbSerieBuletin);
        }

        private void tbNrBuletin_TextChanged(object sender, EventArgs e)
        {
            Program.validareNrBuletin(errorProviderNrBuletin, tbNrBuletin);
        }

        private void tbNrTelefon_TextChanged(object sender, EventArgs e)
        {
            Program.validareNrTelefon(errorProviderNrTelefon, tbNrTelefon);
        }

        private void dtpDataAngajare_ValueChanged(object sender, EventArgs e)
        {
            Program.validareDataAngajare(errorProviderDataAngajare, dtpDataAngajare);
        }

        private void dtpDataNastere_ValueChanged(object sender, EventArgs e)
        {
           if(Program.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp,errorProviderDataNastere) &&  Program.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere,errorProviderDataNastere))
            {
                errorProviderDataNastere.SetError(dtpDataNastere, "");
                errorProviderCnp.SetError(tbCnp, "");
            }

        }

        private void tbCnp_TextChanged(object sender, EventArgs e)
        {
           if( tbCnp.Text.Length == 13)
            {
            Program.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere);
            Program.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere) ;
            }
          

        }

        private bool validareCodVerificare()
        {
            bool eValid = true;
            if(tbCodVerificare.Text != codVerificareTrimis)
            {
                errorProviderCodVerificare.SetError(tbCodVerificare, "Codul de verificare e incorect!");
                eValid = true;
            }
            else
            {
                errorProviderCodVerificare.SetError(tbCodVerificare, "");
            }

            return eValid;
        }
        private bool validareFormular()
        {
            bool eValid = false;

            bool numeValid = Program.validareNume(errorProviderNume, tbInregistrareNume);
            bool prenumeValid = Program.validarePrenume(errorProviderPrenume, tbPrenume);
            bool emailValid = Program.validareEmail(errorProviderEmail, tbEmail);
            bool dataNastereValida = Program.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp,errorProviderDataNastere);
            bool dataAngajariiValida = Program.validareDataAngajare(errorProviderDataAngajare, dtpDataAngajare);
            bool cnpValid = Program.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            bool serieValida = Program.validareSerie(errorProviderSerieBuletin, tbSerieBuletin);
            bool nrvalid = Program.validareNrBuletin(errorProviderNrBuletin, tbNrBuletin);
            bool nrTelefonValid = Program.validareNrTelefon(errorProviderNrTelefon, tbNrTelefon);
            bool parolaValida = Program.validareParola(errorProviderParola, tbParola);
            bool codVerificareValid = validareCodVerificare();
            bool confirmaParolaValid = Program.validareConfirmaParola(errorProviderConfirmaParola, tbParolaConfirmare, tbParola.Text);
           
            if (cnpValid && dataNastereValida)
            {
                errorProviderDataNastere.Clear();
                errorProviderCnp.Clear();
            }
            
            
            if(numeValid && prenumeValid && emailValid &&  dataAngajariiValida  
                && serieValida && nrvalid && nrTelefonValid && parolaValida && codVerificareValid &&confirmaParolaValid)
            {
                eValid = true;
            }
            return eValid;
        }

        #endregion

        #region Error Providers
        private void tbInregistrareNume_Validating(object sender, CancelEventArgs e)
        {

            Program.validareNume(errorProviderNume,tbInregistrareNume);

        } 
        private void tbInregistrareNume_Validated(object sender, EventArgs e)
        {
            errorProviderNume.Clear();
            
        }
        
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {

            Program.validarePrenume(errorProviderPrenume,tbPrenume);
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errorProviderPrenume.Clear();
          
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            Program.validareEmail(errorProviderEmail,tbEmail);
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errorProviderEmail.Clear();
       
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            Program.validareParola(errorProviderParola,tbParola);
        }

        private void tbParola_Validated(object sender, EventArgs e)
        {
            errorProviderParola.Clear();
        }

        private void dtpDataNastere_Validating(object sender, CancelEventArgs e)
        {
            if(tbCnp.Text.Length == 13)
            {
                Program.validareDataNastere(errorProviderCnp,dtpDataNastere,tbCnp,errorProviderDataNastere);
                Program.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            }
            
        }

        private void dtpDataNastere_Validated(object sender, EventArgs e)
        {
            errorProviderDataNastere.Clear();
            errorProviderCnp.Clear();


        }

        private void dtpDataAngajare_Validating(object sender, CancelEventArgs e)
        {
            Program.validareDataAngajare(errorProviderDataAngajare,dtpDataAngajare);
        }

        private void dtpDataAngajare_Validated(object sender, EventArgs e)
        {
            errorProviderDataAngajare.Clear();
       
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            if (tbCnp.Text.Length == 13)
            {
                Program.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere);
                Program.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            }
        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            errorProviderCnp.Clear();
            errorProviderDataNastere.Clear();
       
        }

        private void tbSerieBuletin_Validating(object sender, CancelEventArgs e)
        {
            Program.validareSerie(errorProviderSerieBuletin,tbSerieBuletin);
        }

        private void tbSerieBuletin_Validated(object sender, EventArgs e)
        {
            errorProviderSerieBuletin.Clear();
     
        }

        private void tbNrBuletin_Validating(object sender, CancelEventArgs e)
        {
            Program.validareNrBuletin(errorProviderNrBuletin,tbNrBuletin);
        }

        private void tbNrBuletin_Validated(object sender, EventArgs e)
        {
            errorProviderNrBuletin.Clear();
    
        }

        private void tbNrTelefon_Validating(object sender, CancelEventArgs e)
        {
            Program.validareNrTelefon(errorProviderNrTelefon,tbNrTelefon);
        }

        private void tbNrTelefon_Validated(object sender, EventArgs e)
        {
            errorProviderNrTelefon.Clear();
          
        }

        private void tbCodVerificare_Validating(object sender, CancelEventArgs e)
        {
            validareCodVerificare();
        }

        private void tbCodVerificare_Validated(object sender, EventArgs e)
        {
            errorProviderCodVerificare.Clear();
        }


        private void tbParolaConfirmare_Validated(object sender, EventArgs e)
        {
            errorProviderConfirmaParola.Clear();
        }

        #endregion


        #region Trimitere E-mail Cod Verificare
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
            smtpClient.Send(mail);
            MessageBox.Show("Cod de verificare trimis pe e-mail","Cod de verificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return codVerificare;
        }
        private void btnTrimiteCodVerificare_Click(object sender, EventArgs e)
        {
            codVerificareTrimis = trimiteCodVerificare();
           
        }


        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
