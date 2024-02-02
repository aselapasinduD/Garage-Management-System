using System.Diagnostics;

namespace GarageTuto
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void ownerNameInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carColorInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carModelInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carBrandInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void carNumberInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void carMenuLable_Click(object sender, EventArgs e)
        {

        }

        private void stockMenuLable_Click(object sender, EventArgs e)
        {
 
        }

        private void carPictureLogo_Click(object sender, EventArgs e)
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
