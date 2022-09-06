using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class CardCerereConcediu : UserControl
    {
        public const int IN_ASTEPTARE = 2;
        public const int ACCEPTAT = 1;
        public const int RESPINS = 3; //id-ul pentru tipul de concediu REPSINS, modifica conform db.
        CerereConcediu concediu = new CerereConcediu();
        public CardCerereConcediu(CerereConcediu concediu)
        {
            pbRespins.Hide();
            pbInAsteptare.Hide();
            pbAcceptat.Hide();
            lblMotivRespingere.Hide();
            rtbMotivRespingere.Hide();
            this.concediu = concediu;
            InitializeComponent();
            lblNrConcediu.Text = concediu.cod.ToString();
            lblDataInceput.Text = concediu.dataInceput.ToString();
            lblDataFinal.Text = concediu.dataSfarsit.ToString();
            lblStatus.Text = concediu.stareConcediu.ToString();
            rtbMotivRespingere.ReadOnly = true;
            if (concediu.comentarii.Length < 0)
                rtbMotivCerere.Text = concediu.comentarii;
            else
                rtbMotivCerere.Text = "Nu ati oferit un motiv";
            if (concediu.stareConcediuId == CardCerereConcediu.RESPINS)
            {
                lblMotivRespingere.Show();
                rtbMotivRespingere.Show();
                if (concediu.motivRespingere.Length > 0)
                    rtbMotivRespingere.Text = concediu.motivRespingere;
                else
                    rtbMotivRespingere.Text = "Nu este oferit un motiv";
                pbRespins.Show();
            }
            if (concediu.stareConcediuId == CardCerereConcediu.ACCEPTAT)
                pbAcceptat.Show();
            if(concediu.stareConcediuId == CardCerereConcediu.IN_ASTEPTARE)
                pbInAsteptare.Show();
        }

        public CardCerereConcediu()
        {

        }
        
       
    }
}
