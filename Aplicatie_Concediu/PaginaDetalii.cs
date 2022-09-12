using Aplicatie_Concediu.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class PaginaDetalii : Form
         
    {
        private readonly Tabel_Concedii  refresh;
       
        public PaginaDetalii(Tabel_Concedii Tabel_Concedii)
        {
            refresh = Tabel_Concedii ;
            InitializeComponent();
        }
       
        public Concediu GetConcediu(int idconcediu)
        {
            var url = "http://localhost:5085/api/PaginaDetalii/GetConcediubyId?idConcediu=" + idconcediu;
            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            Concediu con = JsonConvert.DeserializeObject<Concediu>(data);
            return con;
        }

       
        private bool UpdateStareConcediu(Concediu c)
        {
            var requestBody = JsonConvert.SerializeObject(c);
            var requestData = Encoding.UTF8.GetBytes(requestBody);
            string url = "http://localhost:5085/api/PaginaDetalii/UpdateStareConcediu";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = requestData.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(requestData, 0, requestData.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void PaginaDetalii_Load(object sender, EventArgs e)
        {
            
            IdConcediu.Text = Program.IdConcediu;
            Concediu con = GetConcediu(Convert.ToInt32(Program.IdConcediu));
            Nume.Text = con.Angajat.Nume;
            Manager.Text = con.Angajat.Manager.Nume;
            TipConcediu.Text = con.TipConcediu.Nume;
            Inlocuitor.Text = con.Inlocuitor.Nume;
            DataInceput.Text = con.DataInceput.ToString();
            DataFinal.Text = con.DataSfarsit.ToString();
            StareCerereConcediu.Text = con.StareConcediu.Nume;
            Comentariu.Text = con.Comentarii;
            MotivRespingere.Text = con.MotivRespingere;

            if (con.StareConcediu.Nume == "aprobat" || con.StareConcediu.Nume == "respins")
            {
                Aproba.Hide();
                Respinge.Hide();
            }
           


        }

        private void Inchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Aproba_Click(object sender, EventArgs e)
        {
            Concediu con = new Concediu();
            con.Id = Convert.ToInt32(Program.IdConcediu);
            con.StareConcediuId = 1;
            bool stare = UpdateStareConcediu(con);
            await refresh.GetConcedii("http://localhost:5085/api/TabelConcedii/GetConcedii");
            this.Close();
         
        }

        private void Respinge_Click(object sender, EventArgs e)
        {
            Concediu con = new Concediu();
            con.Id = Convert.ToInt32(Program.IdConcediu);
            con.StareConcediuId = 3;
            MotivRespingere motiv = new MotivRespingere(refresh);
            motiv.Show();
            this.Close();


        }
    }
}
