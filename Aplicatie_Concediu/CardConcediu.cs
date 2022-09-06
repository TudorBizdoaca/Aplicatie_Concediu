using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicatie_Concediu.Models;
namespace Aplicatie_Concediu
{
    public partial class CardConcediu : UserControl
    {
        public CardConcediu()
        {
            InitializeComponent();
        }

        public CardConcediu(Concediu concediu)
        {
            InitializeComponent();
            lblDataInceput.Text = concediu.DataInceput.ToString();
            lblDataSfarsit.Text = concediu.DataSfarsit.ToString();
            lblInlocuitor.Text = concediu.Inlocuitor.Nume + " " + concediu.Inlocuitor.Prenume;
            lblStatus.Text = concediu.StareConcediu.Nume;
          
            
            if (concediu.StareConcediu.Nume == "respins" && concediu.Comentarii != string.Empty && concediu.Comentarii != null)
            {
                lblMotivRespingere.Show();
                rtbMotivRespingere.Text = concediu.Comentarii;
                rtbMotivRespingere.Show();
            }
        }

      
    }
}
