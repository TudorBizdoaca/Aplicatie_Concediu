﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class InserareConcediu : Form
    {
        
        DateTime StartDate;
        DateTime EndDate;
        SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
       
        List<int> ListaIduriInConcediu = new List<int>();
        public void cbTipConcediuLoad()
        {
            string query = "select id,nume from TipConcediu";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dtTipConcediu = new DataTable();
            dtTipConcediu.Load(dataReader);
            cbTipConcediu.DataSource = dtTipConcediu;
            cbTipConcediu.DisplayMember = "nume";
            cbTipConcediu.ValueMember = "id";
            dataReader.Close();
        }
        public void cbInlocuitorLoad()
        {

            ListaIduriInConcediu.Clear();

            //SQL STUFF
            string query = "select id, CONCAT(nume,' ', prenume) as Nume from angajat";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dtAngajati = new DataTable();
            dtAngajati.Load(dataReader);



            string query2 = "SELECT angajatId FROM Concediu\r\nWHERE  (dataInceput <= @EndDate ) AND (dataSfarsit >=@StartDate)";
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlParameter param = new SqlParameter("EndDate", EndDate);
            command2.Parameters.Add(param);
            param = new SqlParameter("StartDate", StartDate);
            command2.Parameters.Add(param);
           
            cbInlocuitor.DataSource = dtAngajati;
            cbInlocuitor.DisplayMember = "Nume";
            cbInlocuitor.ValueMember = "id";

            SqlDataReader dataReader2 = command2.ExecuteReader();
           
            
            while (dataReader2.Read())
            {
                ListaIduriInConcediu.Add(int.Parse(dataReader2[0].ToString()));
            }
            
            dataReader.Close();
            dataReader2.Close();

        }
        public InserareConcediu(int AngajatId)
        {
            InitializeComponent();

            connection.Open();

            cbTipConcediuLoad();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;
            
            
        }
       
        private void InserareConcediu_Load(object sender, EventArgs e)
        {


        }



        private void dtpInceputConcediu_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpInceputConcediu.Value;
            EndDate = dtpFinalConcediu.Value;
            cbInlocuitorLoad();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;
           

        }

        private void dtpFinalConcediu_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpInceputConcediu.Value;
            EndDate = dtpFinalConcediu.Value;
            
            cbInlocuitorLoad();
            dtpFinalConcediu.MinDate = dtpInceputConcediu.Value;
           
        }
        public void insertConcediu()
        {
            string query = "INSERT INTO Concediu(tipConcediuId, dataInceput, dataSfarsit, inlocuitorId, comentarii, stareConcediuId,angajatId)" +
                "VALUES(@tipConcediuId,@dataInceput,@dataSfarsit,@inlocuitorId,@comentarii,@stareConcediuId,@angajatId)";
            SqlCommand command = new SqlCommand(query,connection);
           
            command.Parameters.Add(new SqlParameter("tipConcediuId", cbTipConcediu.SelectedValue));
            command.Parameters.Add(new SqlParameter("dataInceput", StartDate));
            command.Parameters.Add(new SqlParameter("dataSfarsit", EndDate));
            command.Parameters.Add(new SqlParameter("inlocuitorId", cbInlocuitor.SelectedValue));
            command.Parameters.Add(new SqlParameter("comentarii", rtfComentarii.Text));
            command.Parameters.Add(new SqlParameter("stareConcediuId", cbTipConcediu.SelectedValue));
            command.Parameters.Add(new SqlParameter("angajatId", Program.UserId));
            command.ExecuteNonQuery();

            MessageBox.Show("Concediu inserat cu succes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbTipConcediu.SelectedItem == null)
            {
                MessageBox.Show("Alege tipul de concediu!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Int32.Parse(dtpFinalConcediu.Value.Date.AddDays(-dtpInceputConcediu.Value.Date.Day).Day.ToString()) < 0
            if (dtpFinalConcediu.Value.Date < dtpInceputConcediu.Value.Date)
            {
                MessageBox.Show("Format data incorect, data de final nu poate sa fie mai mica decat data de inceput", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ListaIduriInConcediu.Count != 0)
            if (ListaIduriInConcediu.Contains(int.Parse(cbInlocuitor.SelectedValue.ToString())))
                if (MessageBox.Show("Inlocuitorul selectat este in concediu pe perioada selectata, esti sigur ca doresti sa il adaugi?", "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                   
                }
                else
                {
                    return;
                }
            insertConcediu();
            
        }

        private void rtfComentarii_KeyPress(object sender, KeyPressEventArgs e)
        { 
            lblCharCount.Text = "Caractere ramase: "+ (500 - (rtfComentarii.Text.Length)).ToString();          
        }
    }
}
