using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
            // Date Utilizator Logat
            pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizatorLogat.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;

            // Validari Butoane Manager & Admin
            if (SesiuneLogIn.angajatLogat.ManagerId == null || SesiuneLogIn.angajatLogat.EsteAdmin == true)
            {
                buttonDetaliiAngajati.Visible = true;
                buttonPanouAdmin.Visible = true;
            }

            // Date PaginaMea
            pictureBoxUtilizator.Image = System.Drawing.Image.FromStream(new MemoryStream(SesiuneLogIn.angajatLogat.Poza));
            labelNumeUtilizator.Text = SesiuneLogIn.angajatLogat.Nume + " " + SesiuneLogIn.angajatLogat.Prenume;
            textBoxNume.Text = SesiuneLogIn.angajatLogat.Nume;
            textBoxPrenume.Text = SesiuneLogIn.angajatLogat.Prenume;
            textBoxCnp.Text = SesiuneLogIn.angajatLogat.Cnp;
            textBoxSerie.Text = SesiuneLogIn.angajatLogat.Serie;
            textBoxNr.Text = SesiuneLogIn.angajatLogat.No;
            textBoxTelefon.Text = SesiuneLogIn.angajatLogat.NrTelefon;
            textBoxEmail.Text = SesiuneLogIn.angajatLogat.Email;
            dateTimePickerDataNasterii.Value = SesiuneLogIn.angajatLogat.DataNasterii;
            dateTimePickerDataAngajarii.Value = SesiuneLogIn.angajatLogat.DataAngajare;
        }
        // Event handler pentru Close


        // Buton Iesire
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;

            Application.Exit();
        }

        // Click Utilizator Logat
        private void pictureBoxUtilizatorLogat_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void labelNumeUtilizatorLogat_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        // Buton Deconectare
        private void labelDeconectare_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            Autentificare formAutentificare = new Autentificare();
            formAutentificare.Show();
            this.Close();
        }

        // Butoane Meniu
        private void buttonPaginaMea_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void buttonCerereConcediu_Click(object sender, EventArgs e)
        {
            InserareConcediu formInserareConcediu = new InserareConcediu();
            formInserareConcediu.Show();
            this.Close();
        }

        private void buttonIstoricConcedii_Click(object sender, EventArgs e)
        {
            IstoricConcedii formIstoricConcedii = new IstoricConcedii();
            formIstoricConcedii.Show();
            this.Close();
        }

        private void buttonDetaliiAngajati_Click(object sender, EventArgs e)
        {
            TabelaAngajati formTabelaAngajati = new TabelaAngajati(1);
            formTabelaAngajati.Show();
            this.Close();
        }

        private void buttonPanouAdmin_Click(object sender, EventArgs e)
        {
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii(1);
            formTabelConcedii.Show();
            this.Close();
        }

        // Butoane Pagina
        private void buttonEditeazaProfil_Click(object sender, EventArgs e)
        {
            pictureBoxUtilizator.Enabled = true;
            textBoxNume.ReadOnly = false;
            textBoxPrenume.ReadOnly = false;
            textBoxCnp.ReadOnly = false;
            textBoxSerie.ReadOnly = false;
            textBoxNr.ReadOnly = false;
            textBoxTelefon.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            dateTimePickerDataNasterii.Enabled = true;
            dateTimePickerDataAngajarii.Enabled = true;

            buttonEditeazaProfil.Visible = false;
            buttonAnuleaza.Visible = true;
            buttonSalveaza.Visible = true;
            pictureBoxEdit.Visible = true;
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            textBoxEmail_Validated(sender, e);





            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            // Update Angajat
            Angajat angajat = new Angajat();
            angajat = SesiuneLogIn.angajatLogat;
            angajat.Nume = textBoxNume.Text;
            angajat.Prenume = textBoxPrenume.Text;
            angajat.Email = textBoxEmail.Text;
            angajat.DataNasterii = dateTimePickerDataNasterii.Value;
            angajat.DataAngajare = dateTimePickerDataAngajarii.Value;
            angajat.Cnp = textBoxCnp.Text;
            angajat.Serie = textBoxSerie.Text;
            angajat.No = textBoxNr.Text;
            angajat.NrTelefon = textBoxTelefon.Text;

            // Convert image to byte array
            byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBoxUtilizator.Image, Type.GetType("System.Byte[]"));

            angajat.Poza = imgBytes;

            if (UpdateUtilizator(angajat))
            {
                SesiuneLogIn.angajatLogat = angajat;

                // Refresh Form
                PaginaMea formPaginaMea = new PaginaMea();
                formPaginaMea.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nu a functionat!");
            }
        }

        private bool UpdateUtilizator(Angajat angajat)
        {
            var requestBody = JsonConvert.SerializeObject(angajat);
            var requestData = Encoding.UTF8.GetBytes(requestBody);

            string URL = String.Format("{0}/PaginaMea/UpdateAngajat", SesiuneLogIn.requestURL);
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(URL));
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = requestData.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(requestData, 0, requestData.Length);

            }
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Upload Image
        private void pictureBoxUtilizator_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxUtilizator.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(textBoxEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxEmail.Select(0, textBoxEmail.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(textBoxEmail, errorMsg);
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }



        private void PaginaMea_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.errorProvider1.Clear();
            this.textBoxEmail_Validated(sender, e);

        }

        private void TextBoxSerie_Validating(object sender, CancelEventArgs e)
        {

            if (!(Utils.ValidariFormular.validareSerie(errorProvider2, textBoxSerie)) || textBoxSerie.Text.Contains(" "))
            {
                e.Cancel = true;
                textBoxSerie.Select(0, textBoxEmail.Text.Length);
                errorProvider2.SetError(textBoxSerie, "Selectai o serie de buletin Valida!");
            }


        }

        private void textBoxSerie_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(textBoxSerie, "");
        }

        private void textBoxCnp_Validated(object sender, EventArgs e)
        {
            errorProvider6.SetError(textBoxCnp, "");
            dateTimePickerDataNasterii.Value = ValidariFormular.extragereDataNastereDinCnp(textBoxCnp.Text);
        }

        private void textBoxCnp_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!ValidariFormular.ValidareCnp(textBoxCnp.Text, out errorMessage))
            {
                e.Cancel = true;
                textBoxCnp.Select(0, textBoxCnp.Text.Length);
                errorProvider6.SetError(textBoxCnp, errorMessage);

            }
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            string nrTelefonRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            Regex nrTelefonRegexp = new Regex(nrTelefonRegex);


            if (!nrTelefonRegexp.IsMatch(textBoxTelefon.Text) || textBoxTelefon.Text.Length > 15)
            {
                e.Cancel = true;
                textBoxTelefon.Select(0, textBoxTelefon.Text.Length);
                errorProvider3.SetError(textBoxTelefon, "Intrduceti un numar de telefon valid");

            }


        }

        private void textBoxTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(textBoxTelefon, "");
        }

        private void textBoxNume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNume.Text == string.Empty && !Regex.IsMatch(textBoxNume.Text, "/^[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+$/u"))
            {
                e.Cancel = true;
                textBoxNume.Select(0, textBoxNume.Text.Length);
                errorProvider4.SetError(textBoxNume, "Introduceti un nume");
            }
        }

        private void textBoxNume_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(textBoxNume, "");
        }

        private void textBoxPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrenume.Text == string.Empty || Regex.IsMatch(textBoxPrenume.Text, "/^[a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+$/u"))
            {
                e.Cancel = true;
                textBoxPrenume.Select(0, textBoxPrenume.Text.Length);
                errorProvider5.SetError(textBoxPrenume, "Introduceti un nume valid");
            }
        }

        private void textBoxPrenume_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(textBoxPrenume, "");
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxUtilizator.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
        }

        private void textBoxNr_Validated(object sender, EventArgs e)
        {
            errorProvider7.SetError(textBoxNr, "");
        }

        private void textBoxNr_Validating(object sender, CancelEventArgs e)
        {
            string nrTelefonRegex = "^[0-9]*$";
            Regex nrTelefonRegexp = new Regex(nrTelefonRegex);

            if (textBoxNr.Text.Length != 6 || !nrTelefonRegexp.IsMatch(textBoxNr.Text) )
            {
                e.Cancel = true;
                textBoxNr.Select(0,textBoxNr.Text.Length);
                errorProvider7.SetError(textBoxNr, "Numar gresit");
                
            }
            
           }

        private void dateTimePickerDataNasterii_ValueChanged(object sender, EventArgs e)
        {
            string dataNastere = dateTimePickerDataNasterii.Value.Year.ToString().Substring(2, 2) + dateTimePickerDataNasterii.Value.Month.ToString() + dateTimePickerDataNasterii.Value.Day.ToString(); ;
            if(dateTimePickerDataNasterii.Value.Year < 2000 && textBoxCnp.Text[0]%2 == 0)
            {
                string foo = '2' + dataNastere + textBoxCnp.Text.Substring(7, 5);
                textBoxCnp.Text = foo;
            }
        }
    }
}

