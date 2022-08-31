using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class Inregistrare : Form
    {
     
       public Inregistrare()
        {
            InitializeComponent();
           
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
        private void btnInregistrare_Click(object sender, EventArgs e)
        {


            if (validareFormular())
            {
                     
                string connectionString = "Data Source=ts2112\\SQLEXPRESS;Initial Catalog=BreakingBread;User ID=internship2022;Password=int";
                SqlParameter pNume = new SqlParameter("@nume",System.Data.SqlDbType.NVarChar, 50);
                pNume.Value = tbInregistrareNume.Text;
                SqlParameter pPrenume = new SqlParameter("@prenume",System.Data.SqlDbType.NVarChar, 50);
                pPrenume.Value = tbPrenume.Text;
                SqlParameter pEmail = new SqlParameter("@email", System.Data.SqlDbType.NVarChar,50);
                pEmail.Value = tbEmail.Text;
                SqlParameter pParola = new SqlParameter("@parola", System.Data.SqlDbType.NVarChar,100);
                pParola.Value = criptareParola(tbParola.Text);
                SqlParameter pDataNastere = new SqlParameter("@dataNasterii", System.Data.SqlDbType.DateTime); ;
                pDataNastere.Value = dtpDataNastere.Value;
                SqlParameter pDataAngajare = new SqlParameter("@dataAngajare", System.Data.SqlDbType.DateTime); ;
                pDataAngajare.Value = dtpDataAngajare.Value;
                SqlParameter pCnp = new SqlParameter("@cnp", System.Data.SqlDbType.NVarChar, 13);
                pCnp.Value = tbCnp.Text;
                SqlParameter pSerieBuletin = new SqlParameter("@serie", System.Data.SqlDbType.NVarChar, 2); ;
                pSerieBuletin.Value = tbSerieBuletin.Text;
                SqlParameter pNrBuletin = new SqlParameter("@no", System.Data.SqlDbType.NVarChar,6); ;
                pNrBuletin.Value = tbNrBuletin.Text;
                SqlParameter pNrTelefon = new SqlParameter("@nrTelefon", System.Data.SqlDbType.NVarChar,20);
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
                    MessageBox.Show("Angajat inserat cu succes!", "Succes Inserare", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private bool validareNume()
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tbInregistrareNume.Text) || String.IsNullOrWhiteSpace(tbInregistrareNume.Text))
            {
                errorProviderNume.SetError(tbInregistrareNume, "Introduceti numele!");
                eValid = false;
            } else
            {
                errorProviderNume.SetError(tbInregistrareNume, "");
            }
            return eValid;
        }
        private bool validarePrenume()
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tbPrenume.Text) || String.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                errorProviderPrenume.SetError(tbPrenume, "Introduceti prenumele!");
                eValid = false;

            }
            else
            {
                errorProviderPrenume.SetError(tbPrenume, "");
            }
            return eValid;
        }
        private bool validareEmail()
        {
            bool eValid = true;
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex emailRegexp = new Regex(emailRegex);
            if (!emailRegexp.IsMatch(tbEmail.Text))
            {
                errorProviderEmail.SetError(tbEmail, "E-mailul nu este valid!");
                eValid = false;
               
            } else
            {
                errorProviderEmail.SetError(tbEmail, "");
            }
            return eValid;
        }
        private bool validareDataNastere()
        {
            bool eValid = true;

            if (dtpDataNastere.Value >= DateTime.Today)
            {
                errorProviderDataNastere.SetError(dtpDataNastere, "Data Nasterii nu poate fi in viitor");
                eValid = false;
               
            }
            else
            {
                errorProviderDataNastere.SetError(dtpDataNastere, "");
            }

            return eValid;
        }

        private bool validareDataAngajare()
        {
            bool esteValid = true;
            if (dtpDataAngajare.Value >= DateTime.Today.AddDays(1))
            {
                errorProviderDataAngajare.SetError(dtpDataAngajare, "Data Angajarii nu poate fi in viitor");
                esteValid = false;

            }
            else
            {
                errorProviderDataAngajare.SetError(dtpDataAngajare, "");
            }

            return esteValid;
        }

        private bool validareParola()
        {
            bool eValid = true;
            string parolaRegex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
            Regex parolaRegexEpr = new Regex(parolaRegex);
            if (!parolaRegexEpr.IsMatch(tbParola.Text))
            {
               
                errorProviderParola.SetError(tbParola, "Parola Invalida!");
                eValid = false;
            }
            else
            {
                errorProviderParola.SetError(tbParola, "");
            }
            return eValid;
        }

        private bool validareCnp()
        {
            bool eValid = true;
            string cnpRegex = @"^[1-9]\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])(0[1-9]|[1-4]\d|5[0-2]|99)(00[1-9]|0[1-9]\d|[1-9]\d\d)\d$";
            Regex cnpRegexExp = new Regex(cnpRegex);
            if (String.IsNullOrEmpty(tbCnp.Text))
            {
                errorProviderCnp.SetError(tbCnp, "Introduceti CNP!");
                eValid = false;
              
            } else if (!cnpRegexExp.IsMatch(tbCnp.Text))
                 {
                errorProviderCnp.SetError(tbCnp, "CNP Invalid!");
                eValid = false;
            } else
            {
                errorProviderCnp.SetError(tbCnp, "");
            }

            return eValid;
        }

        private bool validareSerie()
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tbSerieBuletin.Text) || tbSerieBuletin.Text.Length != 2)
            {
                 errorProviderSerieBuletin.SetError(tbSerieBuletin, "Introduceti o serie de buletin valida!");
                 eValid= false;
              
            } else
            {
                errorProviderSerieBuletin.SetError(tbSerieBuletin, "");
            }

             return eValid;

        }

        private bool validareNrBuletin()
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tbNrBuletin.Text) || tbNrBuletin.Text.Length != 6)
            {
                errorProviderNrBuletin.SetError(tbNrBuletin, "Introduceti un nr de buletin valid!");
                eValid = false;
            
            } else
            {
                errorProviderNrBuletin.SetError(tbNrBuletin, "");
            }

            return eValid;
        }

        private bool validareNrTelefon()
        {
            bool eValid = true;
            string nrTelefonRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            Regex nrTelefonRegexp = new Regex(nrTelefonRegex);


            if (!nrTelefonRegexp.IsMatch(tbNrTelefon.Text))
            {
                errorProviderNrTelefon.SetError(tbNrTelefon, "Nr de telefon invalid!");
                eValid = false;
               
            } else
            {
                errorProviderNrTelefon.SetError(tbNrTelefon, "");
            }
            return eValid;
        }

        private bool validareFormular()
        {
            bool eValid = false;

            bool numeValid = validareNume();
            bool prenumeValid = validarePrenume();
            bool emailValid = validareEmail();
            bool dataNastereValida = validareDataNastere();
            bool dataAngajariiValida = validareDataAngajare();
            bool cnpValid = validareCnp();
            bool serieValida = validareSerie();
            bool nrvalid = validareNrBuletin();
            bool nrTelefonValid = validareNrTelefon();
            bool parolaValida = validareParola();

            if(numeValid && prenumeValid && emailValid && dataNastereValida && dataAngajariiValida && cnpValid 
                && serieValida && nrvalid && nrTelefonValid && parolaValida)
            {
                eValid = true;
            }
            return eValid;
        }

        #endregion

        #region Error Providers
        private void tbInregistrareNume_Validating(object sender, CancelEventArgs e)
        {

            validareNume();

        } 
        private void tbInregistrareNume_Validated(object sender, EventArgs e)
        {
            errorProviderNume.Clear();
            
        }
        
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {

            validarePrenume();
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errorProviderPrenume.Clear();
          
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            validareEmail();
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errorProviderEmail.Clear();
       
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            validareParola();
        }

        private void tbParola_Validated(object sender, EventArgs e)
        {
            errorProviderParola.Clear();
        }

        private void dtpDataNastere_Validating(object sender, CancelEventArgs e)
        {
            validareDataNastere();
        }

        private void dtpDataNastere_Validated(object sender, EventArgs e)
        {
            errorProviderDataNastere.Clear();
         
        }

        private void dtpDataAngajare_Validating(object sender, CancelEventArgs e)
        {
            validareDataAngajare();
        }

        private void dtpDataAngajare_Validated(object sender, EventArgs e)
        {
            errorProviderDataAngajare.Clear();
       
        }

        private void tbCnp_Validating(object sender, CancelEventArgs e)
        {
            validareCnp();
        }

        private void tbCnp_Validated(object sender, EventArgs e)
        {
            errorProviderCnp.Clear();
       
        }

        private void tbSerieBuletin_Validating(object sender, CancelEventArgs e)
        {
            validareSerie();
        }

        private void tbSerieBuletin_Validated(object sender, EventArgs e)
        {
            errorProviderSerieBuletin.Clear();
     
        }

        private void tbNrBuletin_Validating(object sender, CancelEventArgs e)
        {
            validareNrBuletin();
        }

        private void tbNrBuletin_Validated(object sender, EventArgs e)
        {
            errorProviderNrBuletin.Clear();
    
        }

        private void tbNrTelefon_Validating(object sender, CancelEventArgs e)
        {
            validareNrTelefon();
        }

        private void tbNrTelefon_Validated(object sender, EventArgs e)
        {
            errorProviderNrTelefon.Clear();
          
        }

        #endregion
    }

}
