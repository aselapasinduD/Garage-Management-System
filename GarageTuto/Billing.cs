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

namespace GarageTuto
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            displayDataSet();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        int partId = 0;

        //Stock information Functions
        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Stock";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);

            var dataSet = new DataSet();
            SDA.Fill(dataSet);
            stockDataGrid.DataSource = dataSet.Tables[0];

            Database.Close();
        }
    }
}
