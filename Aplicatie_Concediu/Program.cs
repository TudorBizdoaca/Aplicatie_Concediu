using Aplicatie_Concediu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
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

        #region Criptare Parola
        public static string criptareParola(string parola)
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
