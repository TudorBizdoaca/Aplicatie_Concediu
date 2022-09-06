using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicatie_Concediu.Models;
using Newtonsoft.Json;

namespace Aplicatie_Concediu
{
    
    public partial class TabelaAngajati : Form
    {
        const string ImagePath = "C:\\Users\\gunal.sadic\\Downloads\\PozaDefaultAngajati";
        static readonly HttpClient client = new HttpClient();
        public  TabelaAngajati()
        {
            
            InitializeComponent();
        }
        List<Angajat> Angajati = new List<Angajat>();
        async Task GetAngajati()
        {
        
            HttpResponseMessage response =  await client.GetAsync("http://localhost:5085/api/Angajat/GetAngajati");
            string responseBody = await response.Content.ReadAsStringAsync();
            Angajati = JsonConvert.DeserializeObject<List<Angajat>>(responseBody);
            var source = new BindingSource();
            source.DataSource = Angajati;
            dgvAngajati.DataSource = source;
            dgvAngajati.Columns.Remove("Manager");
            dgvAngajati.Columns.Remove("ConcediuAngajats");
            dgvAngajati.Columns.Remove("ConcediuInlocuitors");
            dgvAngajati.Columns.Remove("InverseManager");
            
           
        }

        private void TabelaAngajati_Load(object sender, EventArgs e)
        {
            GetAngajati();
           
        }

    
    }
}
