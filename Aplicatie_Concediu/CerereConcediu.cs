using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_Concediu
{
   public class CerereConcediu
    {
        public int id;
        public int tipConcediuId;
        public string tipConcediu;
        public DateTime dataInceput;
        public DateTime dataSfarsit;
        public int inlocuitorId;
        public string comentarii;
        public string motivRespingere;
        public int stareConcediuId;
        public string stareConcediu;
        public int angajatId;
        public int cod;

        public CerereConcediu(int id, int tipConcediuId, string stareConcediu, string tipConcediu, DateTime dataInceput, DateTime dataSfarsit, int inlocuitorId, string comentarii, string motivRespingere, int stareConcediuId, int angajatId, int cod)
        {
            this.stareConcediu = stareConcediu;
            this.id = id;
            this.tipConcediuId = tipConcediuId;
            this.tipConcediu = tipConcediu;
            this.dataInceput = dataInceput;
            this.dataSfarsit = dataSfarsit;
            this.inlocuitorId = inlocuitorId;
            this.comentarii = comentarii;
            this.motivRespingere = motivRespingere;
            this.stareConcediuId = stareConcediuId;
            this.angajatId = angajatId;
            this.cod = cod;
        }

        public CerereConcediu()
        {
        }
    }
}
