using Aplicatie_Concediu.Models;
using Aplicatie_Concediu.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            // Validari Butoane Manager
            if (SesiuneLogIn.angajatLogat.ManagerId == null)
            {
                buttonDetaliiAngajati.Visible = true;
            }

            // Validari Butoane Admini
            if (SesiuneLogIn.angajatLogat.EsteAdmin == true)
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

        // Buton Iesire
        private void buttonIesire_Click(object sender, EventArgs e)
        {
            SesiuneLogIn.angajatLogat = null;
            this.Close();
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
            TabelaAngajati formTabelaAngajati = new TabelaAngajati();
            formTabelaAngajati.Show();
            this.Close();
        }

        private void buttonPanouAdmin_Click(object sender, EventArgs e)
        {
            Tabel_Concedii formTabelConcedii = new Tabel_Concedii();
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
        }

        private void buttonAnuleaza_Click(object sender, EventArgs e)
        {
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            // Validari


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
            string url = "http://localhost:5085/api/PaginaMea/UpdateAngajat";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
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
    }
}
