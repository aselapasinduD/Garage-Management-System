using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageTuto
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void priceInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void quantityInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void partNumberInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Add Button is Clicked");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Edit Button is Clicked");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Delete Button is Clicked");
        }

        // Menu Click Events
        private void carMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void stockMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void employeesMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void billingMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void analyticsMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void logoutMenuLable_Click(object sender, EventArgs e)
        {

        }
    }
}
