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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void adminSignIn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (employeeNameInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show(
                    "Empty Value Input Error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            DataTable dataTabel = new DataTable();
            try
            {
                Database.Open();
                SqlDataAdapter SDA = new SqlDataAdapter("SELECT count(*) FROM Employee WHERE EmpName='" + employeeNameInput.Text + "' and EmpPassword='" + passwordInput.Text + "'", Database);
                SDA.Fill(dataTabel);
                Database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error From Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            if (dataTabel.Rows[0][0].ToString() == "1")
            {
                MainWindow mainWindow = new MainWindow("Employee", employeeNameInput.Text);
                mainWindow.Show();
                this.Hide();
                return;
            }
            MessageBox.Show(
                "Entered User Name or Password is Wrong.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
    }
}
