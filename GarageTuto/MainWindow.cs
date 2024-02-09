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
        public MainWindow()
        {
            InitializeComponent();
            loadForm(new Cars());
        }

        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
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
        }

        private void stockMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Stock());
        }

        private void employeesMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Employees());
        }

        private void billingMenuLable_Click(object sender, EventArgs e)
        {
            loadForm(new Billing());
        }

        private void analyticsMenuLable_Click(object sender, EventArgs e)
        {

        }
    }
}
