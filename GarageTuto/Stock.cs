using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            displayDataSet();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        int partId = 0;

        //Stock information Functions
        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Stock";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);

            var dataSet = new DataSet();
            SDA.Fill(dataSet);
            stockInformationDataGrid.DataSource = dataSet.Tables[0];

            Database.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool checkInput = partNameInput.Text == "" || quantityInput.Text == "" || priceInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }

            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Stock(PartName, PartQuantity, PartPrice) VALUES(@Pn,@Pq,@Pp)", Database);
                cmd.Parameters.AddWithValue("@Pn", partNameInput.Text);
                cmd.Parameters.AddWithValue("@Pq", quantityInput.Text);
                cmd.Parameters.AddWithValue("@Pp", priceInput.Text);
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
            if (partId == 0)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM Stock WHERE PartId=@Pid", Database);
                cmd.Parameters.AddWithValue("@Pid", partId);
                cmd.ExecuteNonQuery();
                Database.Close();
                displayDataSet();
                clearInputs();
                stockInformationDataGrid.ClearSelection();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool checkInput = partNameInput.Text == "" || quantityInput.Text == "" || priceInput.Text == "";
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }

            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Stock SET PartName=@Pn,PartQuantity=@Pq,PartPrice=@Pp", Database);
                cmd.Parameters.AddWithValue("@Pn", partNameInput.Text);
                cmd.Parameters.AddWithValue("@Pq", quantityInput.Text);
                cmd.Parameters.AddWithValue("@Pp", priceInput.Text);
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

        private void stockInformationDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Set SelectedRowCarNumber
                if (stockInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString() == null)
                {
                    return;
                }
                partId = Convert.ToInt32(stockInformationDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                partNameInput.Text = stockInformationDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                quantityInput.Text = stockInformationDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                priceInput.Text = stockInformationDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }
        private void clearInputs()
        {
            partNameInput.Text = "";
            quantityInput.Text = "";
            priceInput.Text = "";
            partId = 0;
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
