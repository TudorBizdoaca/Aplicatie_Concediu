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
            ConcediuAngajats = new HashSet<Concediu>();
            ConcediuInlocuitors = new HashSet<Concediu>();
            InverseManager = new HashSet<Angajat>();
        }

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; } 
        public string Email { get; set; }
        public string Parola { get; set; }
        public DateTime DataAngajare { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Cnp { get; set; } 
        public string Serie { get; set; } 
        public string No { get; set; }
        public string NrTelefon { get; set; }

        public byte[] Poza { get; set; }
        public bool? EsteAdmin { get; set; }
        public int? ManagerId { get; set; }
        public int? ZileConcediu { get; set; }
        
        public virtual Angajat Manager { get; set; }
        
        public virtual ICollection<Concediu> ConcediuAngajats { get; set; }
        public virtual ICollection<Concediu> ConcediuInlocuitors { get; set; }
        public virtual ICollection<Angajat> InverseManager { get; set; }
    }
}

