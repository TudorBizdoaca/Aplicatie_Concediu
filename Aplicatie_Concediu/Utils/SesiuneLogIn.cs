using Aplicatie_Concediu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Aplicatie_Concediu.Utils
{
    public static class SesiuneLogIn
    {
        public static Angajat angajatLogat;

        public static string requestURL = "http://localhost:5085/api";
    }
}
