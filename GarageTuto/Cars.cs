using System.Diagnostics;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace GarageTuto
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
            displayDataSet();
        }
        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Cars";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);

            var dataSet = new DataSet();
            SDA.Fill(dataSet);
            carInformationDataGrid.DataSource = dataSet.Tables[0];

            Database.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool checkInput = carNumberInput.Text == "" || carBrandInput.Text == "" || carModelInput.Text == "" || carColorInput.Text == "" || ownerNameInput.Text == "";
            /*Debug.WriteLine(carNumberInput.Text);*/
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }
            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cars(CarNumber, CarBrand, CarModel, CarDate, CarColor, OwnerName) VALUES(@Cn,@Cb,@Cm,@Cd,@Cc,@On)", Database);
                cmd.Parameters.AddWithValue("@Cn", carNumberInput.Text);
                cmd.Parameters.AddWithValue("@Cb", carBrandInput.Text);
                cmd.Parameters.AddWithValue("@Cm", carModelInput.Text);
                cmd.Parameters.AddWithValue("@Cd", carInformationDate.Value.Date);
                cmd.Parameters.AddWithValue("@Cc", carColorInput.Text);
                cmd.Parameters.AddWithValue("@On", ownerNameInput.Text);
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
