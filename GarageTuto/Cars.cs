using System.Diagnostics;
using System.Data.SqlClient;
using System.Text;

namespace GarageTuto
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }
        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");
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
            bool checkInput = carNumberInput.Text == "" || carBrandInput.Text == "" || carModelInput.Text == "" || carColorInput.Text == "" || ownerNameInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }

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

        private void carInforamationDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
