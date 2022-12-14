using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
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

        public bool InrengistrareAngajatAPI(Angajat ang)
        {
            var requestBody = JsonConvert.SerializeObject(ang);
            var requestData = Encoding.UTF8.GetBytes(requestBody);
            string URL = "http://localhost:5085/api/PaginaInregistrare/InsertAngajat";
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(URL));
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
                ang.ManagerId = 20;
 
                string imgFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,"Utils", "PozaDefaultAngajati.png");
                ang.Poza = ImgConvert.ConvertImageToByteArray(imgFilePath);
                bool d = InrengistrareAngajatAPI(ang);
                if (d == true)
                {
                    MessageBox.Show("Angajat inserat cu succes!", "Succes Inserare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Autentificare autentificare = new Autentificare();
                    autentificare.Show();
                }
                else
                {
                    MessageBox.Show("Inserarea a esuat!", "Eroare Inserare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Formularul contine erori!", "Erori validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ValidariFormular.validareNume(errorProviderNume, tbInregistrareNume);
        }

        private void tbPrenume_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validarePrenume(errorProviderPrenume, tbPrenume);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareEmail(errorProviderEmail, tbEmail);
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareParola(errorProviderParola, tbParola);
        }

        private void tbParolaConfirmare_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareConfirmaParola(errorProviderConfirmaParola, tbParolaConfirmare, tbParola.Text);
        }

        private void tbSerieBuletin_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareSerie(errorProviderSerieBuletin, tbSerieBuletin);
        }

        private void tbNrBuletin_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareNrBuletin(errorProviderNrBuletin, tbNrBuletin);
        }

        private void tbNrTelefon_TextChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareNrTelefon(errorProviderNrTelefon, tbNrTelefon);
        }

        private void dtpDataAngajare_ValueChanged(object sender, EventArgs e)
        {
            ValidariFormular.validareDataAngajare(errorProviderDataAngajare, dtpDataAngajare,tbCnp.Text);
        }

        private void dtpDataNastere_ValueChanged(object sender, EventArgs e)
        {
            if (ValidariFormular.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere) && ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere))
            {
                errorProviderDataNastere.SetError(dtpDataNastere, "");
                errorProviderCnp.SetError(tbCnp, "");
            }
         
         

        }


        private bool validareCodVerificare()
        {
            bool eValid = true;
            if (tbCodVerificare.Text != codVerificareTrimis)
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

            bool numeValid = ValidariFormular.validareNume(errorProviderNume, tbInregistrareNume);
            bool prenumeValid = ValidariFormular.validarePrenume(errorProviderPrenume, tbPrenume);
            bool emailValid = ValidariFormular.validareEmail(errorProviderEmail, tbEmail);
            bool dataNastereValida = ValidariFormular.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere);
            bool dataAngajariiValida = ValidariFormular.validareDataAngajare(errorProviderDataAngajare, dtpDataAngajare,tbCnp.Text);
            bool cnpValid = ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            bool serieValida = ValidariFormular.validareSerie(errorProviderSerieBuletin, tbSerieBuletin);
            bool nrvalid = ValidariFormular.validareNrBuletin(errorProviderNrBuletin, tbNrBuletin);
            bool nrTelefonValid = ValidariFormular.validareNrTelefon(errorProviderNrTelefon, tbNrTelefon);
            bool parolaValida = ValidariFormular.validareParola(errorProviderParola, tbParola);
            bool codVerificareValid = validareCodVerificare();
            bool confirmaParolaValid = ValidariFormular.validareConfirmaParola(errorProviderConfirmaParola, tbParolaConfirmare, tbParola.Text);
            bool existaEmail = ValidariFormular.existaEmail;
            if (cnpValid && dataNastereValida)
            {
                errorProviderDataNastere.Clear();
                errorProviderCnp.Clear();
            }


            if (numeValid && prenumeValid && emailValid && dataAngajariiValida
                && serieValida && nrvalid && nrTelefonValid && parolaValida && codVerificareValid && confirmaParolaValid && !existaEmail)
            {
                eValid = true;
            }
            return eValid;
        }

        #endregion

        #region Error Providers
        private void tbInregistrareNume_Validating(object sender, CancelEventArgs e)
        {

            ValidariFormular.validareNume(errorProviderNume, tbInregistrareNume);

        }
     
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {

            ValidariFormular.validarePrenume(errorProviderPrenume, tbPrenume);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareEmail(errorProviderEmail, tbEmail);
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareParola(errorProviderParola, tbParola);
        }

       
        private void dtpDataNastere_Validating(object sender, CancelEventArgs e)
        {
            if (tbCnp.Text.Length == 13)
            {
                ValidariFormular.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere);
                ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            }

        }
 
        private void dtpDataAngajare_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareDataAngajare(errorProviderDataAngajare, dtpDataAngajare,tbCnp.Text);
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            if (tbCnp.Text.Length == 13)
            {
                ValidariFormular.validareDataNastere(errorProviderCnp, dtpDataNastere, tbCnp, errorProviderDataNastere);
                ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
            }
        }

   
        private void tbSerieBuletin_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareSerie(errorProviderSerieBuletin, tbSerieBuletin);
        }

        

        private void tbNrBuletin_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareNrBuletin(errorProviderNrBuletin, tbNrBuletin);
        }

        private void tbNrTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidariFormular.validareNrTelefon(errorProviderNrTelefon, tbNrTelefon);
        }

        private void tbCodVerificare_Validating(object sender, CancelEventArgs e)
        {
            validareCodVerificare();
        }


        private void tbCnp_TextChanged_1(object sender, EventArgs e)
        {
            ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere);
        }

        private void tbCodVerificare_TextChanged(object sender, EventArgs e)
        {
            validareCodVerificare();
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
            smtpClient.Credentials = new NetworkCredential("EMAIL", "PAROLA");
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show("Trimitere esuata!!", "Esec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Cod de verificare trimis pe e-mail", "Cod de verificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return codVerificare;
        }
        private void btnTrimiteCodVerificare_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Introdu un e-mail!", "E-mail lipsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                codVerificareTrimis = trimiteCodVerificare();
            }


        }


        #endregion

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

        #region Apelare validari pe event-ul de leave
        private void tbEmail_Leave(object sender, EventArgs e)
        {
            ValidariFormular.verificareExistentaEmail(errorProviderEmail, tbEmail, tbEmail.Text);
            ValidariFormular.validareEmail(errorProviderEmail, tbEmail);
        }

        private void tbCnp_Leave_1(object sender, EventArgs e)
        {
            if (ValidariFormular.verificareCifreCnp(tbCnp.Text, errorProviderCnp, tbCnp, dtpDataNastere, errorProviderDataNastere))
            {
                dtpDataNastere.Value = Utils.ValidariFormular.extragereDataNastereDinCnp(tbCnp.Text);
                errorProviderCnp.Clear();
                errorProviderDataNastere.Clear();
                DateTime dataN = ValidariFormular.extragereDataNastereDinCnp(tbCnp.Text);
                if (DateTime.Today.Year - dataN.Year < 18)
                {
                    errorProviderCnp.SetError(tbCnp, "Varsta minima este de 18 ani!!!!!!!");
                }
            }

        }
      private void tbInregistrareNume_Leave_1(object sender, EventArgs e)
        {
            ValidariFormular.validareNume(errorProviderNume, tbInregistrareNume);
        }

        private void tbPrenume_Leave_1(object sender, EventArgs e)
        {
            ValidariFormular.validarePrenume(errorProviderPrenume, tbPrenume);
        }

        private void tbCodVerificare_Leave(object sender, EventArgs e)
        {
            validareCodVerificare();
        }
        #endregion

        #region Permitere doar litere in nume prenume si serie

        private void tbInregistrareNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbPrenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void tbSerieBuletin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }



        #endregion

       
    }

}
