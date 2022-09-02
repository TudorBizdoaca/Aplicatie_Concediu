using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
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
            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();

            string query = "select * from Angajat where id = '" + Program.UserId + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);

                byte[] imgBytes = (byte[])reader["poza"];
                string nume = Convert.ToString(reader["nume"]);
                string prenume = Convert.ToString(reader["prenume"]);
                string email = Convert.ToString(reader["email"]);
                string parola = Convert.ToString(reader["parola"]);
                DateTime dataAngajare = Convert.ToDateTime(reader["dataAngajare"]);
                DateTime dataNasterii = Convert.ToDateTime(reader["dataNasterii"]);
                string cnp = Convert.ToString(reader["cnp"]);
                string serie = Convert.ToString(reader["serie"]);
                string no = Convert.ToString(reader["no"]);
                string nrTelefon = Convert.ToString(reader["nrTelefon"]);

                pictureBoxUtilizatorLogat.Image = System.Drawing.Image.FromStream(new MemoryStream(imgBytes));
                labelNumeUtilizatorLogat.Text = nume + " " + prenume;

                pictureBoxUtilizator.Image = System.Drawing.Image.FromStream(new MemoryStream(imgBytes));
                labelNumeUtilizator.Text = nume + " " + prenume;
                textBoxNume.Text = nume;
                textBoxPrenume.Text = prenume;
                textBoxCnp.Text = cnp;
                textBoxSerie.Text = serie;
                textBoxNr.Text = no;
                textBoxTelefon.Text = nrTelefon;
                textBoxEmail.Text = email;
                dateTimePickerDataNasterii.Value = dataNasterii;
                dateTimePickerDataAngajarii.Value = dataAngajare;
            }

            connection.Close();
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
            InserareConcediu formInserareConcediu = new InserareConcediu(Program.UserId);
            formInserareConcediu.ShowDialog();
            formInserareConcediu.Focus();
        }

        private void buttonIstoricConcedii_Click(object sender, EventArgs e)
        {
            IstoricConcedii formIstoricConcedii = new IstoricConcedii();
            formIstoricConcedii.ShowDialog();
            formIstoricConcedii.Focus();
        }

        private void buttonDetaliiAngajati_Click(object sender, EventArgs e)
        {
            TabelaAngajati formTabelaAngajati = new TabelaAngajati();
            formTabelaAngajati.ShowDialog();
            formTabelaAngajati.Focus();
        }

        private void buttonPanouAdmin_Click(object sender, EventArgs e)
        {
            PanouAdmin formPanouAdmin = new PanouAdmin();
            formPanouAdmin.ShowDialog();
            formPanouAdmin.Focus();
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
            SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.Int);
            id.Value = Program.UserId;
            SqlParameter nume = new SqlParameter("@nume", System.Data.SqlDbType.NVarChar, 50);
            nume.Value = textBoxNume.Text;
            SqlParameter prenume = new SqlParameter("@prenume", System.Data.SqlDbType.NVarChar, 50);
            prenume.Value = textBoxPrenume.Text;
            SqlParameter email = new SqlParameter("@email", System.Data.SqlDbType.NVarChar, 50);
            email.Value = textBoxEmail.Text;
            SqlParameter dataAngajare = new SqlParameter("@dataAngajare", System.Data.SqlDbType.DateTime); ;
            dataAngajare.Value = dateTimePickerDataAngajarii.Value;
            SqlParameter dataNasterii = new SqlParameter("@dataNasterii", System.Data.SqlDbType.DateTime); ;
            dataNasterii.Value = dateTimePickerDataNasterii.Value;
            SqlParameter cnp = new SqlParameter("@cnp", System.Data.SqlDbType.NVarChar, 13);
            cnp.Value = textBoxCnp.Text;
            SqlParameter serie = new SqlParameter("@serie", System.Data.SqlDbType.NVarChar, 2); ;
            serie.Value = textBoxSerie.Text;
            SqlParameter no = new SqlParameter("@no", System.Data.SqlDbType.NVarChar, 6); ;
            no.Value = textBoxNr.Text;
            SqlParameter nrTelefon = new SqlParameter("@nrTelefon", System.Data.SqlDbType.NVarChar, 20);
            nrTelefon.Value = textBoxTelefon.Text;

            // Convert image to byte array
            byte[] imgBytes = null;
            ImageConverter imgConverter = new ImageConverter();
            imgBytes = (System.Byte[])imgConverter.ConvertTo(pictureBoxUtilizator.Image, Type.GetType("System.Byte[]"));

            SqlParameter poza = new SqlParameter("@poza", System.Data.SqlDbType.VarBinary);
            poza.Value = imgBytes;

            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();

            string query = "update Angajat set nume = @nume, prenume = @prenume, email = @email, dataAngajare = @dataAngajare, dataNasterii = @dataNasterii, cnp = @cnp, serie = @serie, no = @no, nrTelefon = @nrTelefon, poza = @poza where id = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(id);
            command.Parameters.Add(nume);
            command.Parameters.Add(prenume);
            command.Parameters.Add(email);
            command.Parameters.Add(dataAngajare);
            command.Parameters.Add(dataNasterii);
            command.Parameters.Add(cnp);
            command.Parameters.Add(serie);
            command.Parameters.Add(no);
            command.Parameters.Add(nrTelefon);
            command.Parameters.Add(poza);
            command.ExecuteNonQuery();

            connection.Close();

            // Refresh Form
            PaginaMea formPaginaMea = new PaginaMea();
            formPaginaMea.Show();
            this.Close();
        }

        // Upload Image
        private void pictureBoxUtilizator_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    byte[] imgBytes = File.ReadAllBytes(fileName);

                    pictureBoxUtilizator.Image = System.Drawing.Image.FromStream(new MemoryStream(imgBytes));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Autentificare formAutentificare = new Autentificare();
            formAutentificare.Show();
            this.Close();
        }
    }
}
