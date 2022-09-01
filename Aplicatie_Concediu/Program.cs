using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    internal static class Program
    {
        public static int UserId { get; set; }
        public static string IdConcediu { get; set; }
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
