using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
