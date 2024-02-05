using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageTuto
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void addButton_Click(object sender, EventArgs e)
        {
            bool checkInput = employeeNameInput.Text == "" || employeeAddressInput.Text == "" || employeePasswordInput.Text == "" || genderBox.Text == "" ;
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }
            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee(EmpName, EmpGender, EmpAddress, EmpPassword) VALUES(@En,@Eg,@Ea,@Ep)", Database);
                cmd.Parameters.AddWithValue("@En", employeeNameInput.Text);
                cmd.Parameters.AddWithValue("@Eg", genderBox.Text);
                cmd.Parameters.AddWithValue("@Ea", employeeAddressInput.Text);
                cmd.Parameters.AddWithValue("@Ep", employeePasswordInput.Text);
                cmd.ExecuteNonQuery();
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Data Is Added Successfully");
                Database.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
            Debug.WriteLine("Add Button is Clicked");
        }
    }
}
