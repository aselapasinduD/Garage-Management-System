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
        string selectedRowCarNumber = "";

        //Car information Functions
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
                Database.Close();
                displayDataSet();
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Data Is Added Successfully");
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool checkInput = carNumberInput.Text == "" || carBrandInput.Text == "" || carModelInput.Text == "" || carColorInput.Text == "" || ownerNameInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }
            if(selectedRowCarNumber != carNumberInput.Text)
            {
                DialogResult dialogResult = MessageBox.Show(
                "You Can't Edit Car Number.",
                "Stop",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop
                );
                return;
            }
            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Cars SET CarBrand=@Cb,CarModel=@Cm,CarDate=@Cd,CarColor=@Cc,OwnerName=@On WHERE CarNumber=@Cn", Database);
                cmd.Parameters.AddWithValue("@Cn", carNumberInput.Text);
                cmd.Parameters.AddWithValue("@Cb", carBrandInput.Text);
                cmd.Parameters.AddWithValue("@Cm", carModelInput.Text);
                cmd.Parameters.AddWithValue("@Cd", carInformationDate.Value.Date);
                cmd.Parameters.AddWithValue("@Cc", carColorInput.Text);
                cmd.Parameters.AddWithValue("@On", ownerNameInput.Text);
                cmd.ExecuteNonQuery();
                Database.Close();
                displayDataSet();
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Data Is Edited Successfully");
                clearInputs();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(selectedRowCarNumber == "")
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "There is no any Selected Row to Delete. Deleting Is Failed");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure? Do you want to Delete?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.No) return;

            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Cars WHERE CarNumber=@Cn", Database);
                cmd.Parameters.AddWithValue("@Cn", selectedRowCarNumber);
                cmd.ExecuteNonQuery();
                Database.Close();
                displayDataSet();
                clearInputs();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void carInformationDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Set SelectedRowCarNumber
                if (carInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString() == null)
                {
                    return;
                }
                selectedRowCarNumber = carInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString();

                carNumberInput.Text = selectedRowCarNumber;
                carBrandInput.Text = carInformationDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                carModelInput.Text = carInformationDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                carInformationDate.Value = DateTime.Parse(carInformationDataGrid.SelectedRows[0].Cells[3].Value.ToString());
                carColorInput.Text = carInformationDataGrid.SelectedRows[0].Cells[4].Value.ToString();
                ownerNameInput.Text = carInformationDataGrid.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }
        
        // Menu Section functions
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

        private void clearInputs()
        {
            carNumberInput.Text = "";
            carBrandInput.Text = "";
            carModelInput.Text = "";
            carInformationDate.Value = DateTime.Now.Date;
            carColorInput.Text = "";
            ownerNameInput.Text = "";
            selectedRowCarNumber = "";
        }
    }
}
