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
using System.Windows.Forms.VisualStyles;

namespace GarageTuto
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            displayDataSet();
            getCarNumberList();
        }

        SqlConnection Database = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asela\\OneDrive\\Documents\\GMSDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        int partId = 0, partRemoveIndex = -1, price = 0, totalFees = 0, totalPartsFees = 0;
        string partName = "";


        //Stock information Functions
        private void displayDataSet()
        {
            Database.Open();

            String dataQuery = "SELECT * FROM Stock";
            SqlDataAdapter SDA = new SqlDataAdapter(dataQuery, Database);

            var dataSet = new DataSet();
            SDA.Fill(dataSet);
            stockDataGrid.DataSource = dataSet.Tables[0];

            Database.Close();
        }
        private void getCarNumberList()
        {
            Database.Open();

            SqlCommand cmd = new SqlCommand("SELECT CarNumber FROM Cars", Database);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("CarNumber", typeof(string));
            dataTable.Load(reader);

            Database.Close();

            carNumberBox.ValueMember = "CarNumber";
            carNumberBox.DataSource = dataTable;
        }

        private void carNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Database.Open();

                SqlCommand cmd = new SqlCommand("SELECT CarDate,OwnerName FROM Cars WHERE CarNumber=@Cn", Database);
                cmd.Parameters.AddWithValue("@Cn", carNumberBox.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                carOwnerNameShowLabel.Text = reader[1].ToString();
                carDateShowingLabel.Text = DateTime.Parse(reader[0].ToString()).ToString("MM/dd/yyyy");
                reader.Close();

                /*while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Debug.WriteLine("{0} ", reader[i]);
                    }
                }*/
                Database.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

        }

        private void stockDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            partId = Convert.ToInt32(stockDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            partName = stockDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            price = Convert.ToInt32(stockDataGrid.SelectedRows[0].Cells[3].Value.ToString());
        }

        int number = 0;
        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (partId == 0 || partName == "" || price == 0)
            {
                MessageBox.Show(
                    "You Need to Select A Part from the Stock Table.",
                    "Waring",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;

            }
            try
            {
                int quantityInputValue = Convert.ToInt32(quantityInput.Text);
                if (!(Convert.ToInt32(stockDataGrid.SelectedRows[0].Cells[2].Value) >= quantityInputValue))
                {
                    MessageBox.Show(
                        "Not Enough Stock.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    return;
                }

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billingDataGrid);
                newRow.Cells[0].Value = number += 1;
                newRow.Cells[1].Value = partId;
                newRow.Cells[2].Value = partName;
                newRow.Cells[3].Value = quantityInput.Text;
                newRow.Cells[4].Value = price;
                newRow.Cells[5].Value = quantityInputValue * price;
                billingDataGrid.Rows.Add(newRow);

                stockDataGrid.SelectedRows[0].Cells[2].Value = Convert.ToInt32(stockDataGrid.SelectedRows[0].Cells[2].Value) - quantityInputValue;
                updateTotalPrice();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
        }

        private void billingDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            partRemoveIndex = billingDataGrid.Rows.IndexOf(billingDataGrid.SelectedRows[0]);
        }

        private void removePartButton_Click(object sender, EventArgs e)
        {
            if (partRemoveIndex == -1)
            {
                MessageBox.Show(
                    "You need to select the row.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
            try
            {
                if (stockDataGrid.SelectedRows[0].Cells[0].Value.Equals(billingDataGrid.Rows[partRemoveIndex].Cells[1].Value))
                {
                    stockDataGrid.SelectedRows[0].Cells[2].Value = Convert.ToInt32(stockDataGrid.SelectedRows[0].Cells[2].Value) + Convert.ToInt32(billingDataGrid.Rows[partRemoveIndex].Cells[3].Value);
                }
                else
                {
                    var billingPartId = billingDataGrid.Rows[partRemoveIndex].Cells[1].Value;

                    for (int i = 0; i < stockDataGrid.RowCount; ++i)
                    {
                        if (stockDataGrid.Rows[i].Cells[0].Value.Equals(billingPartId))
                        {
                            stockDataGrid.Rows[i].Cells[2].Value = Convert.ToInt32(stockDataGrid.Rows[i].Cells[2].Value) + Convert.ToInt32(billingDataGrid.Rows[partRemoveIndex].Cells[3].Value);
                        }
                    }
                }
                billingDataGrid.Rows.RemoveAt(partRemoveIndex);
                //number -= 1;
                updateTotalPrice();
            }
            catch (ArgumentOutOfRangeException)
            {
                partRemoveIndex = -1;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < billingDataGrid.RowCount; ++i)
            {
                Debug.WriteLine("{0}", billingDataGrid.Rows[i].Cells[2].Value);
            }

            bool checkInput = carNumberBox.SelectedValue.ToString() == "" || totalFees == 0;
            if (checkInput)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", "Empty Data Input Error");
                return;
            }

            try
            {
                Database.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Bills(CarNum, BillingDate, MechFees, PartFees, TotalFees, EmployeeName) VALUES(@Cn,@Bd,@Mf,@Pf,@Tf,@En)", Database);
                cmd.Parameters.AddWithValue("@Cn", carNumberBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Bd", billingDatePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Mf", mechanicsFeeInput.Text);
                cmd.Parameters.AddWithValue("@Pf", totalPartsFees);
                cmd.Parameters.AddWithValue("@Tf", totalFees);
                cmd.Parameters.AddWithValue("@En", employeeName.Text);
                cmd.ExecuteNonQuery();
                Database.Close();
                displayDataSet();

                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Bill is Successfully Saved.");
            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }

            try
            {
                Database.Open();
                for (int i = 0; i < billingDataGrid.RowCount; ++i)
                {
                    var billingPartId = billingDataGrid.Rows[i].Cells[1].Value;

                    for (int x = 0; x < stockDataGrid.RowCount; ++x)
                    {
                        if (!stockDataGrid.Rows[x].Cells[0].Value.Equals(billingPartId))
                        {
                            continue;
                        }

                        int newQuantity = Convert.ToInt32(stockDataGrid.Rows[i].Cells[2].Value);

                        SqlCommand cmd = new SqlCommand("UPDATE Stock SET PartQuantity=@Pq WHERE PartId=@Pid", Database);
                        cmd.Parameters.AddWithValue("@Pid", billingPartId);
                        cmd.Parameters.AddWithValue("@Pq", newQuantity);
                        cmd.ExecuteNonQuery();
                    }
                }
                Database.Close();
                displayDataSet();
                billingDataGrid.Rows.Clear();

                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Success", "Part Quantity is Successfully Updated.");

            }
            catch (Exception ex)
            {
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.Show("Warning", ex.Message);
            }
        }

        private void updateTotalPrice()
        {
            try
            {
                totalFees = 0 + Convert.ToInt32(mechanicsFeeInput.Text);
            }
            catch
            {
                totalFees = 0;
            }
            totalPartsFees = 0;

            for (int i = 0; i < billingDataGrid.RowCount; ++i)
            {
                totalFees += Convert.ToInt32(billingDataGrid.Rows[i].Cells[5].Value);
                totalPartsFees += Convert.ToInt32(billingDataGrid.Rows[i].Cells[5].Value);
            }
            totalPriceNumber.Text = totalFees.ToString();
        }

        private void updateStockQuantityDatabase(int partId, int quantity)
        {

        }

        private void mechanicsFeeInput_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }

        // Menu changing Functions
        private void carMenuLable_Click(object sender, EventArgs e)
        {
            Cars obj = new Cars();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Location = this.Location;
            obj.Show();
            this.Hide();
        }

        private void stockMenuLable_Click(object sender, EventArgs e)
        {
            Stock obj = new Stock();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Location = this.Location;
            obj.Show();
            this.Hide();
        }

        private void employeesMenuLable_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Location = this.Location;
            obj.Show();
            this.Hide();
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
