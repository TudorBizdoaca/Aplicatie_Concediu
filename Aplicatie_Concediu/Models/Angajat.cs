using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Concediu.Models
{
    public partial class Angajat
    {
        public Angajat()
        {

        }

        public int Id { get; set; }
        public string Nume { get; set; } = null;
        public string Prenume { get; set; } = null;
        public string Email { get; set; }
        public string Parola { get; set; }
        public DateTime DataAngajare { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Cnp { get; set; } = null;
        public string Serie { get; set; } = null;
        public string No { get; set; } = null;
        public string NrTelefon { get; set; }
        public byte[] Poza { get; set; }
        public bool EsteAdmin { get; set; }
        public int ManagerId { get; set; }
        public int ZileConcediu { get; set; }


    }
}

