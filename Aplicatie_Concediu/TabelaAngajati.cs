using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Concediu
{
    public partial class TabelaAngajati : Form
    {       
        //Functie pentru create coloane, am realizat ca pot sa folosesc constructorul dar deja am creat functia
      
        public DataColumn buildColumn(DataColumn coloana, String dataType, String name, Boolean nullable = true, Boolean isUnique = false, Boolean isReadOnly = false)
        {
            coloana = new DataColumn();
            coloana.DataType = System.Type.GetType(dataType);
            coloana.ColumnName = name;
            coloana.AllowDBNull = nullable;
            coloana.Unique = isUnique;
            coloana.ReadOnly = isReadOnly;
            return coloana;
        }
      
        public void CreateDataTable()
        {   
            DataTable dtAngajati = new DataTable();
            DataColumn coloana = new DataColumn();
            buildColumn(coloana,"System.Int32", "id", false, true);
            dtAngajati.Columns.Add(coloana);

            buildColumn(coloana, "System.String", "nume");
            dtAngajati.Columns.Add(coloana);

            buildColumn(coloana, "System.String", "prenume");
            dtAngajati.Columns.Add(coloana);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dtAngajati.Columns[0];
            dtAngajati.PrimaryKey = PrimaryKeyColumns;

            SqlConnection connection = new SqlConnection(@"Data Source = ts2112\SQLEXPRESS; Initial Catalog = BreakingBread; Persist Security Info = True; User ID = internship2022; Password = int ");
            connection.Open();
            string query = "select id, nume, prenume, from Angajat;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dtAngajati.Rows.Add(reader);
            }

        }
        public void FillDataTable()
        {
            
        }
        public TabelaAngajati()
        {
            InitializeComponent();
            CreateDataTable();
        }

       
    }
}
