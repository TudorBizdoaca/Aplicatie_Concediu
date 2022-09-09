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
            //SqlConnection cn = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            //cn.Open();
            IdConcediu.Text = Program.IdConcediu;
            //SqlCommand cmd = new SqlCommand("select c.id as [Id Concediu], concat(a.Nume,' ', a.Prenume) as Nume, concat(a2.Nume,' ', a2.Prenume) as Manager,t.nume as \"Tip Concediu\",concat(a3.Nume,' ', a3.Prenume) as Inlocuitor,  c.dataInceput as [Data Inceput], c.dataSfarsit as [Data Final]  , s.nume as \"Stare Cerere Concediu\", c.comentarii as [Comentariu]\r\nfrom Angajat a\r\njoin Concediu c on c.angajatId = a.id\r\njoin StareConcediu s on s.id = c.stareConcediuId\r\njoin TipConcediu t on t.id = c.tipConcediuId\r\njoin Angajat a2 on a2.Id = a.ManagerId\r\njoin Angajat a3 on a3.Id = c.InlocuitorId\r\nwhere c.id = @IdConcediu",cn);
            //cmd.Connection = cn;
            //cmd.Parameters.Add("IdConcediu", Program.IdConcediu);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while(dr.Read())
            //{

           
            Concediu con = GetConcediu(Convert.ToInt32(Program.IdConcediu));
            Nume.Text = con.Angajat.Nume;
            Manager.Text = con.Angajat.Manager.Nume;
            TipConcediu.Text = con.TipConcediu.Nume;
            Inlocuitor.Text = con.Inlocuitor.Nume;
            DataInceput.Text = con.DataInceput.ToString();
            DataFinal.Text = con.DataSfarsit.ToString();
            StareCerereConcediu.Text = con.StareConcediu.Nume;
            Comentariu.Text = con.Comentarii;
            if(con.StareConcediu.Nume == "aprobat" || con.StareConcediu.Nume == "respins")
            {
                Aproba.Hide();
                Respinge.Hide();
            }
            //}
            //dr.Close();
            //cn.Close();


        }

        private void Inchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aproba_Click(object sender, EventArgs e)
        {
            Concediu con = new Concediu();
            con.Id = Convert.ToInt32(Program.IdConcediu);
            con.StareConcediuId = 1;
            bool stare = UpdateStareConcediu(con);
            refresh.repopulareGvDupaSelectStare();
            this.Close();
         
        }

        private void Respinge_Click(object sender, EventArgs e)
        {
            Concediu con = new Concediu();
            con.Id = Convert.ToInt32(Program.IdConcediu);
            con.StareConcediuId = 3;
            bool stare = UpdateStareConcediu(con);
            refresh.repopulareGV();
            this.Close();
            
        }
    }
}
