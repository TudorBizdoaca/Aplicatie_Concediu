﻿using Aplicatie_Concediu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
   
    public partial class MotivRespingere : Form
         
    {
        private readonly Tabel_Concedii refresh;
  
        public MotivRespingere(Tabel_Concedii tabel_concedii)
        {
            InitializeComponent();
            refresh = tabel_concedii;
        }
        private bool UpdateMotivRespingere(Concediu c)
        {
            var requestBody = JsonConvert.SerializeObject(c);
            var requestData = Encoding.UTF8.GetBytes(requestBody);
            string url = "http://localhost:5085/api/MotivRespingere/updateMotivRespingereConcediu";
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
        private void Motiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblCharCount.Text = "Caractere ramase: " + (500 - (Motiv.Text.Length)).ToString();
        }

        private async void Salveaza_Click(object sender, EventArgs e)
        {
            Concediu con = new Concediu();
            con.Id = Convert.ToInt32(Program.IdConcediu);
            con.MotivRespingere = Motiv.Text;
            con.StareConcediuId = 3;
            bool comentariu = UpdateMotivRespingere(con);
            await refresh.GetConcedii("http://localhost:5085/api/TabelConcedii/GetConcedii");
            this.Close();
            
        }

        private void Anuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
