using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace GarageTuto
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            displayDataSet();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        //Car information Functions
        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Employee";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);

            var dataSet = new DataSet();
            SDA.Fill(dataSet);
            employeeInformationDataGrid.DataSource = dataSet.Tables[0];

            Database.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool checkInput = employeeNameInput.Text == "" || employeeAddressInput.Text == "" || employeePasswordInput.Text == "" || genderInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }
            if (genderInput.Text == "Gender")
            {
                MessageBox.Show(
                    "You must need to select gender",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employee(EmpName, EmpGender, EmpAddress, EmpPassword) VALUES(@En,@Eg,@Ea,@Ep)", Database);
                cmd.Parameters.AddWithValue("@En", employeeNameInput.Text);
                cmd.Parameters.AddWithValue("@Eg", genderInput.Text);
                cmd.Parameters.AddWithValue("@Ea", employeeAddressInput.Text);
                cmd.Parameters.AddWithValue("@Ep", employeePasswordInput.Text);
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
            Debug.WriteLine("Add Button is Clicked");
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
