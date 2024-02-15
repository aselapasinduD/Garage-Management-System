using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageTuto
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void employeeSignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if(passwordInput.Text == "")
            {
                MessageBox.Show(
                    "Please Enter the Password.",
                    "No Enter Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            if(passwordInput.Text != "Admin")
            {
                MessageBox.Show(
                    "Please Enter the right Password.",
                    "Worng Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            MainWindow mainWindow = new MainWindow("Admin", "Admin");
            mainWindow.Show();
            this.Close();
        }
    }
}
