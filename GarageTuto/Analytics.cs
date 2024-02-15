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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            updateAnalytics();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Work\\C# Projects\\Garage Management System\\GarageTuto\\GMSDatabase.mdf\";Integrated Security=True");

        private void updateAnalytics()
        {
            // Car Analytics
            SqlDataAdapter carSDA = new SqlDataAdapter("SELECT Count(*) FROM Cars", Database);
            DataTable carTabel = new DataTable();
            carSDA.Fill(carTabel);
            carNumber.Text = carTabel.Rows[0][0].ToString();

            // Stock Analytics
            SqlDataAdapter stockSDA = new SqlDataAdapter("SELECT Count(*) FROM Stock", Database);
            DataTable stockTabel = new DataTable();
            stockSDA.Fill(stockTabel);
            stockNumber.Text = stockTabel.Rows[0][0].ToString();

            // Employees Analytics
            SqlDataAdapter employeesSDA = new SqlDataAdapter("SELECT Count(*) FROM Employee", Database);
            DataTable employeesTabel = new DataTable();
            employeesSDA.Fill(employeesTabel);
            employeesNumber.Text = employeesTabel.Rows[0][0].ToString();

            // Finance Analytics
            SqlDataAdapter financeSDA = new SqlDataAdapter("SELECT Sum(TotalFees) FROM Bills", Database);
            DataTable financeTabel = new DataTable();
            financeSDA.Fill(financeTabel);
            financeNumber.Text = financeTabel.Rows[0][0].ToString();
        }
    }
}
