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
    public partial class MainWindow : Form
    {
        private static String Role = "";
        public MainWindow(String role, String userName)
        {
            InitializeComponent();

            if (role == "Admin")
                loadForm(new Analytics());
            else
            {
                loadForm(new Billing(userName));
                stockMenuLable.BackColor = Color.Transparent;
                carMenuLable.BackColor = Color.Transparent;
                employeesMenuLable.BackColor = Color.Transparent;
                employeesMenuLable.ForeColor = Color.DimGray;
                billingMenuLable.BackColor = Color.Black;
                analyticsMenuLable.BackColor = Color.Transparent;
            }

            Role = role;
            UserName.Text = userName;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (Role != "")
                Application.Exit();
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                var Panel = this.mainPanel.Controls[0];
                this.mainPanel.Controls.RemoveAt(0);
                Panel.Dispose();
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }

        private void carMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Cars());
            stockMenuLable.BackColor = Color.Transparent;
            carMenuLable.BackColor = Color.Black;
            employeesMenuLable.BackColor = Color.Transparent;
            billingMenuLable.BackColor = Color.Transparent;
            analyticsMenuLable.BackColor = Color.Transparent;
        }

        private void stockMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Stock());
            stockMenuLable.BackColor = Color.Black;
            carMenuLable.BackColor = Color.Transparent;
            employeesMenuLable.BackColor = Color.Transparent;
            billingMenuLable.BackColor = Color.Transparent;
            analyticsMenuLable.BackColor = Color.Transparent;
        }

        private void employeesMenuLable_Click(object sender, EventArgs e)
        {
            if (Role != "Admin")
            {
                MessageBox.Show(
                    "Only Admin Have Access.",
                    "Admin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            loadForm(new Employees());
            stockMenuLable.BackColor = Color.Transparent;
            carMenuLable.BackColor = Color.Transparent;
            employeesMenuLable.BackColor = Color.Black;
            billingMenuLable.BackColor = Color.Transparent;
            analyticsMenuLable.BackColor = Color.Transparent;
        }

        private void billingMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Billing(UserName.Text));
            stockMenuLable.BackColor = Color.Transparent;
            carMenuLable.BackColor = Color.Transparent;
            employeesMenuLable.BackColor = Color.Transparent;
            billingMenuLable.BackColor = Color.Black;
            analyticsMenuLable.BackColor = Color.Transparent;
        }

        private void analyticsMenuLable_Click(object sender, EventArgs e)
        {

            loadForm(new Analytics());
            stockMenuLable.BackColor = Color.Transparent;
            carMenuLable.BackColor = Color.Transparent;
            employeesMenuLable.BackColor = Color.Transparent;
            billingMenuLable.BackColor = Color.Transparent;
            analyticsMenuLable.BackColor = Color.Black;
        }

        private void logoutMenuLable_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Role = "";
            this.Close();
        }
    }
}
