using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Inregistrare : Form
    {
       bool isValid = true;
       public Inregistrare()
        {
            InitializeComponent();
           
        }

        private void validareDate()
        {
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex emailRegexp = new Regex(emailRegex);
            string nrTelefonRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            Regex nrTelefonRegexp = new Regex(nrTelefonRegex);
            if (String.IsNullOrEmpty(tbInregistrareNume.Text))
            {
                errorProviderNume.SetError(tbInregistrareNume, "Introduceti numele!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(tbPrenume.Text))
            {
                errorProviderPrenume.SetError(tbPrenume, "Introduceti prenumele!");
                isValid = false;
            }
            if (!emailRegexp.IsMatch(tbEmail.Text))
            {
                errorProviderEmail.SetError(tbEmail, "E-mailul nu este valid!");
                isValid = false;
            }
            if (!nrTelefonRegexp.IsMatch(tbNrTelefon.Text))
            {
                errorProviderNrTelefon.SetError(tbNrTelefon, "Nr de telefon invalid!");
            }
            if (String.IsNullOrEmpty(tbCnp.Text))
            {
                errorProviderCnp.SetError(tbCnp, "Introduceti CNP!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(tbSerieBuletin.Text))
            {
                errorProviderSerieBuletin.SetError(tbSerieBuletin, "Introduceti seria de buletin!");
                isValid = false;
            }
            if (String.IsNullOrEmpty(tbNrBuletin.Text))
            {
                errorProviderNrBuletin.SetError(tbNrBuletin, "Introduceti nr de buletin!");
                isValid = false;
            }
            if (dtpDataNastere.Value > DateTime.Now)
            {
                errorProviderDataNastere.SetError(dtpDataNastere, "Data Nasterii nu poate fi in viitor");
                isValid = false;
            }
            if (dtpDataAngajare.Value > DateTime.Now)
            {
                errorProviderDataAngajare.SetError(dtpDataAngajare, "Data Angajarii nu poate fi in viitor");
                isValid = false;
            }

        }
        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            validareDate();

            if (isValid)
            {
                // insert in bd
                string connectionString = "Data Source=ts2112\\SQLEXPRESS;Initial Catalog=BreakingBread;User ID=internship2022;Password=int";
                SqlParameter pNume = new SqlParameter("@nume",System.Data.SqlDbType.VarChar);
                pNume.Value = tbInregistrareNume.Text;
                SqlParameter pPrenume = new SqlParameter("@prenume",System.Data.SqlDbType.VarChar);
                pPrenume.Value = tbPrenume.Text;
                SqlParameter pEmail = new SqlParameter("@email", System.Data.SqlDbType.VarChar);
                pEmail.Value = tbEmail.Text;
                SqlParameter pParola = new SqlParameter("@parola", System.Data.SqlDbType.VarChar);
                
                SqlParameter pDataNastere = new SqlParameter("@dataNasterii", System.Data.SqlDbType.DateTime); ;
                pDataNastere.Value = dtpDataNastere.Value;
                SqlParameter pDataAngajare = new SqlParameter("@dataAngajare", System.Data.SqlDbType.DateTime); ;
                pDataAngajare.Value = dtpDataAngajare.Value;
                SqlParameter pCnp = new SqlParameter("@cnp", System.Data.SqlDbType.VarChar); ;
                pCnp.Value = tbCnp.Text;
                SqlParameter pSerieBuletin = new SqlParameter("@serie", System.Data.SqlDbType.VarChar); ;
                pSerieBuletin.Value = tbSerieBuletin.Text;
                SqlParameter pNrBuletin = new SqlParameter("@no", System.Data.SqlDbType.VarChar); ;
                pNrBuletin.Value = tbNrBuletin.Text;
                SqlParameter pNrTelefon = new SqlParameter("@nrTelefon", System.Data.SqlDbType.VarChar);
                pNrTelefon.Value = tbNrTelefon.Text;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                string insertQuery = "INSERT INTO [Angajat] ([nume], [prenume], [email], " +
                    "[parola],[dataAngajare],[dataNasterii],[cnp],[serie],[no],[nrTelefon])" +
                    "" +
                    " VALUES (@nume, @prenume, @email, @parola, @dataAngajare, @dataNasterii, @cnp, @serie, @no, @nrTelefon" +
                    ")";

                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.Parameters.Add(pNume);
                insertCommand.Parameters.Add(pPrenume);
                insertCommand.Parameters.Add(pEmail);
                insertCommand.Parameters.Add(pParola);
                insertCommand.Parameters.Add(pDataAngajare);
                insertCommand.Parameters.Add(pDataNastere);
                insertCommand.Parameters.Add(pCnp);
                insertCommand.Parameters.Add(pSerieBuletin);
                insertCommand.Parameters.Add(pNrBuletin);
                insertCommand.Parameters.Add(pNrTelefon);

                sqlConnection.Open();
                int n = insertCommand.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Angajat inserat cu succes!", "Erori validare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            } else
            {
                MessageBox.Show("Formularul contine erori!","Erori validare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // nu permit sa introduca decat cifre
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
    }
}
