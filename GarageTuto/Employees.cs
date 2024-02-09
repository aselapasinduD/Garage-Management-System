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
        int employeeId = 0;
        //Car information Functions
        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Employee";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);

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
                clearInputs();

                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Data Is Added Successfully");
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeId == 0)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmpId=@Eid", Database);
                cmd.Parameters.AddWithValue("@Eid", employeeId);
                cmd.ExecuteNonQuery();
                Database.Close();
                displayDataSet();
                clearInputs();
                employeeInformationDataGrid.ClearSelection();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool checkInput = employeeNameInput.Text == "" || employeeAddressInput.Text == "" || employeePasswordInput.Text == "" || genderInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }

            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Employee SET EmpName=@En,EmpGender=@Eg,EmpAddress=@Ea,EmpPassword=@Ep", Database);
                cmd.Parameters.AddWithValue("@En", employeeNameInput.Text);
                cmd.Parameters.AddWithValue("@Eg", genderInput.Text);
                cmd.Parameters.AddWithValue("@Ea", employeeAddressInput.Text);
                cmd.Parameters.AddWithValue("@Ep", employeePasswordInput.Text);
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

        private void employeeInformationDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Set SelectedRowCarNumber
                if (employeeInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString() == null)
                {
                    return;
                }
                employeeId = Convert.ToInt32(employeeInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                employeeNameInput.Text = employeeInformationDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                genderInput.Text = employeeInformationDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                employeeAddressInput.Text = employeeInformationDataGrid.SelectedRows[0].Cells[3].Value.ToString();
                employeePasswordInput.Text = employeeInformationDataGrid.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }
        private void clearInputs()
        {
            employeeNameInput.Text = "";
            employeeAddressInput.Text = "";
            employeePasswordInput.Text = "";
            genderInput.Text = "Gender";
            employeeId = 0;
        }
    }
}
