using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void buttonEditeazaProfil_Click(object sender, EventArgs e)
        {
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
            InitializeComponent();
        }
    }
}
