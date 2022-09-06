using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    internal static class Program
    {
        
        public static int UserId  { get; set;  }
       
        public static string IdConcediu { get; set; }

        public static int EsteAdmin { get; set; }

        #region Metode Validare date angajat

        public static bool validareNume(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tb.Text) || String.IsNullOrWhiteSpace(tb.Text))
            {
                ep.SetError(tb, "Introduceti numele!");
                eValid = false;
            }
            else
            {
                ep.SetError(tb, "");
            }
            return eValid;
        }

        public static bool validarePrenume(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tb.Text) || String.IsNullOrWhiteSpace(tb.Text))
            {
                ep.SetError(tb, "Introduceti prenumele!");
                eValid = false;

            }
            else
            {
                ep.SetError(tb, "");
            }
            return eValid;
        }

        public static bool validareEmail(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex emailRegexp = new Regex(emailRegex);
            if (!emailRegexp.IsMatch(tb.Text))
            {
                ep.SetError(tb, "E-mailul nu este valid!");
                eValid = false;

            }
            else
            {
                ep.SetError(tb, "");
            }
            return eValid;
        }

        public static bool validareDataNastere(ErrorProvider ep, DateTimePicker dtp, TextBox tb)
        {
            bool eValid = true;
            DateTime dataNastereCnp = extragereDataNastereDinCnp(dtp.Text, ep, tb, dtp);
            if (dtp.Value >= DateTime.Today)
            {
                ep.SetError(dtp, "Data Nasterii trebuie sa fie in trecut!");
                eValid = false;


            }
            else if (dtp.Value != dataNastereCnp)
            {
                ep.SetError(dtp, "Data Nasterii trebuie sa corespunda cu cea din CNP");
           //     MessageBox.Show(dtp.Value.ToString(), "");
               // MessageBox.Show(dataNastereCnp.ToString(), "");
                eValid = false;

            }
            else
            {
                ep.SetError(dtp, "");

            }

            return eValid;
        }


        public static bool validareDataAngajare(ErrorProvider ep, DateTimePicker dtp)
        {
            bool esteValid = true;
            if (dtp.Value >= DateTime.Today.AddDays(1))
            {
                ep.SetError(dtp, "Data Angajarii nu poate fi in viitor");
                esteValid = false;

            }
            else
            {
                ep.SetError(dtp, "");
            }

            return esteValid;
        }

        public static bool validareSerie(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tb.Text) || tb.Text.Length != 2)
            {
                ep.SetError(tb, "Introduceti o serie de buletin valida!");
                eValid = false;

            }
            else
            {
                ep.SetError(tb, "");
            }

            return eValid;

        }


        public static bool validareNrBuletin(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            if (String.IsNullOrEmpty(tb.Text) || tb.Text.Length != 6)
            {
                ep.SetError(tb, "Introduceti un nr de buletin valid!");
                eValid = false;

            }
            else
            {
                ep.SetError(tb, "");
            }

            return eValid;
        }


        public static bool validareNrTelefon(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            string nrTelefonRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$";
            Regex nrTelefonRegexp = new Regex(nrTelefonRegex);


            if (!nrTelefonRegexp.IsMatch(tb.Text))
            {
                ep.SetError(tb, "Nr de telefon invalid!");
                eValid = false;

            }
            else
            {
                ep.SetError(tb, "");
            }
            return eValid;
        }

        public static bool validareParola(ErrorProvider ep, TextBox tb)
        {
            bool eValid = true;
            string parolaRegex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
            Regex parolaRegexEpr = new Regex(parolaRegex);
            if (!parolaRegexEpr.IsMatch(tb.Text))
            {

                ep.SetError(tb, "Parola Invalida!");
                eValid = false;
            }
            else
            {
                ep.SetError(tb, "");
            }
            return eValid;
        }

        public static DateTime extragereDataNastereDinCnp(string cnp, ErrorProvider ep, TextBox tb, DateTimePicker dtp)
        {
            DateTime dataNasterii = DateTime.Today;
            string dataNastere = "";
            switch (cnp.Substring(0, 1))
            {
                case "1":
                    dataNastere = "19" + cnp.Substring(1, 6);
                    break;
                case "2":
                    dataNastere = "19" + cnp.Substring(1, 6);
                    break;
                case "5":
                    dataNastere = "20" + cnp.Substring(1, 6);
                    break;
                case "6":
                    dataNastere = "20" + cnp.Substring(1, 6);

                        break;
                }
            MessageBox.Show("datan string" + dataNastere, "");
            
                CultureInfo provider = CultureInfo.InvariantCulture;
                try
                {
                    dataNasterii = DateTime.ParseExact(dataNastere, "yyyymmdd", provider);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            MessageBox.Show("dataExtrasa " + dataNasterii.ToString(), "");
                if (dataNasterii != dtp.Value)
                {
                    ep.SetError(tb, "CNP Invalid! Data nasterii e invalida!");
                }
            
            return dataNasterii;
        }

        public static bool verificareCifreCnp(string cnp, ErrorProvider ep, TextBox tb, DateTimePicker dtp)
        {
            bool eValid = true;
            DateTime dataNasterii = cnp.Length ==13 ? extragereDataNastereDinCnp(cnp,ep,tb,dtp) : new DateTime();
            int codJudet = 0;
            if (cnp.Length > 9)
            {
                int.TryParse(cnp.Substring(7, 2), out codJudet);
            }

            if (String.IsNullOrEmpty(cnp) || String.IsNullOrWhiteSpace(cnp))
            {
                ep.SetError(tb, "Introduceti un CNP!");
                eValid = false;
            }
            else if (cnp.Length != 13)
            {

                ep.SetError(tb, "CNP Invalid! Lungimea trebuie sa fie 13!");
                eValid = false;
            }
            else if (dataNasterii > DateTime.Today)
            {
                ep.SetError(tb, "CNP Invalid! Data nasterii e in viitor!");
                eValid = false;
            }
            else if (cnp.Substring(0, 1) == "0" || cnp.Substring(0, 1) == "3" || cnp.Substring(0, 1) == "4")
            {
                ep.SetError(tb, "CNP Invalid!! Prima cifra poate fi 1,2,5,6,7,8 sau 9");

            }
            else if (codJudet < 1 || codJudet > 52)
            {
                ep.SetError(tb, "CNP Invalid! Coduri Judet valide intre 1 si 52!");
            }
            else
            {
                ep.SetError(tb, "");
            }

            return eValid;
        }

        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autentificare());
        }
    }

}
