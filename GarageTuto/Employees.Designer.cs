namespace GarageTuto
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            employeePasswordInputLable = new Label();
            employeeAddressInputLable = new Label();
            employeeNameInputLable = new Label();
            employeePasswordInput = new MaskedTextBox();
            employeeAddressInput = new MaskedTextBox();
            employeeInformationLableHead = new Label();
            employeeNameInput = new MaskedTextBox();
            panel1 = new Panel();
            EmployeeTable = new Panel();
            numberOfEmployees = new Label();
            employeeInformationDataGrid = new DataGridView();
            numberOfEmployeesLabel = new Label();
            genderInput = new ComboBox();
            manageEmployeesTitleHead = new Label();
            panel1.SuspendLayout();
            EmployeeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeInformationDataGrid).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Salmon;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Segoe UI", 12F);
            deleteButton.Location = new Point(368, 117);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 33);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.PaleGreen;
            editButton.Cursor = Cursors.Hand;
            editButton.Font = new Font("Segoe UI", 12F);
            editButton.Location = new Point(193, 117);
            editButton.Name = "editButton";
            editButton.Size = new Size(145, 33);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.SkyBlue;
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.Location = new Point(18, 117);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 33);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // employeePasswordInputLable
            // 
            employeePasswordInputLable.AutoSize = true;
            employeePasswordInputLable.Font = new Font("Segoe UI", 12F);
            employeePasswordInputLable.Location = new Point(472, 48);
            employeePasswordInputLable.Name = "employeePasswordInputLable";
            employeePasswordInputLable.Size = new Size(148, 21);
            employeePasswordInputLable.TabIndex = 2;
            employeePasswordInputLable.Text = "Employee Password";
            // 
            // employeeAddressInputLable
            // 
            employeeAddressInputLable.AutoSize = true;
            employeeAddressInputLable.Font = new Font("Segoe UI", 12F);
            employeeAddressInputLable.Location = new Point(245, 48);
            employeeAddressInputLable.Name = "employeeAddressInputLable";
            employeeAddressInputLable.Size = new Size(138, 21);
            employeeAddressInputLable.TabIndex = 2;
            employeeAddressInputLable.Text = "Employee Address";
            // 
            // employeeNameInputLable
            // 
            employeeNameInputLable.AutoSize = true;
            employeeNameInputLable.Font = new Font("Segoe UI", 12F);
            employeeNameInputLable.Location = new Point(18, 48);
            employeeNameInputLable.Name = "employeeNameInputLable";
            employeeNameInputLable.Size = new Size(124, 21);
            employeeNameInputLable.TabIndex = 2;
            employeeNameInputLable.Text = "Employee Name";
            // 
            // employeePasswordInput
            // 
            employeePasswordInput.Font = new Font("Segoe UI", 10F);
            employeePasswordInput.Location = new Point(472, 72);
            employeePasswordInput.Name = "employeePasswordInput";
            employeePasswordInput.Size = new Size(200, 25);
            employeePasswordInput.TabIndex = 1;
            // 
            // employeeAddressInput
            // 
            employeeAddressInput.Font = new Font("Segoe UI", 10F);
            employeeAddressInput.Location = new Point(245, 72);
            employeeAddressInput.Name = "employeeAddressInput";
            employeeAddressInput.Size = new Size(200, 25);
            employeeAddressInput.TabIndex = 1;
            // 
            // employeeInformationLableHead
            // 
            employeeInformationLableHead.AutoSize = true;
            employeeInformationLableHead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            employeeInformationLableHead.ForeColor = Color.White;
            employeeInformationLableHead.Location = new Point(3, 12);
            employeeInformationLableHead.Name = "employeeInformationLableHead";
            employeeInformationLableHead.Size = new Size(234, 30);
            employeeInformationLableHead.TabIndex = 0;
            employeeInformationLableHead.Text = "Employee Information";
            // 
            // employeeNameInput
            // 
            employeeNameInput.Font = new Font("Segoe UI", 10F);
            employeeNameInput.Location = new Point(18, 72);
            employeeNameInput.Name = "employeeNameInput";
            employeeNameInput.Size = new Size(200, 25);
            employeeNameInput.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(EmployeeTable);
            panel1.Controls.Add(manageEmployeesTitleHead);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 2;
            // 
            // EmployeeTable
            // 
            EmployeeTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeeTable.BackColor = Color.DarkGray;
            EmployeeTable.Controls.Add(numberOfEmployees);
            EmployeeTable.Controls.Add(employeeInformationDataGrid);
            EmployeeTable.Controls.Add(numberOfEmployeesLabel);
            EmployeeTable.Controls.Add(genderInput);
            EmployeeTable.Controls.Add(deleteButton);
            EmployeeTable.Controls.Add(editButton);
            EmployeeTable.Controls.Add(addButton);
            EmployeeTable.Controls.Add(employeePasswordInputLable);
            EmployeeTable.Controls.Add(employeeAddressInputLable);
            EmployeeTable.Controls.Add(employeeNameInputLable);
            EmployeeTable.Controls.Add(employeePasswordInput);
            EmployeeTable.Controls.Add(employeeAddressInput);
            EmployeeTable.Controls.Add(employeeNameInput);
            EmployeeTable.Controls.Add(employeeInformationLableHead);
            EmployeeTable.Location = new Point(185, 40);
            EmployeeTable.Margin = new Padding(8);
            EmployeeTable.Name = "EmployeeTable";
            EmployeeTable.Size = new Size(1154, 677);
            EmployeeTable.TabIndex = 3;
            // 
            // numberOfEmployees
            // 
            numberOfEmployees.AutoSize = true;
            numberOfEmployees.BackColor = Color.Transparent;
            numberOfEmployees.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfEmployees.Location = new Point(1079, 145);
            numberOfEmployees.Name = "numberOfEmployees";
            numberOfEmployees.Size = new Size(17, 20);
            numberOfEmployees.TabIndex = 8;
            numberOfEmployees.Text = "0";
            // 
            // employeeInformationDataGrid
            // 
            employeeInformationDataGrid.AllowUserToAddRows = false;
            employeeInformationDataGrid.AllowUserToDeleteRows = false;
            employeeInformationDataGrid.AllowUserToResizeColumns = false;
            employeeInformationDataGrid.AllowUserToResizeRows = false;
            employeeInformationDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeInformationDataGrid.BackgroundColor = Color.White;
            employeeInformationDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            employeeInformationDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            employeeInformationDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            employeeInformationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            employeeInformationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            employeeInformationDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            employeeInformationDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            employeeInformationDataGrid.GridColor = Color.Black;
            employeeInformationDataGrid.ImeMode = ImeMode.Off;
            employeeInformationDataGrid.Location = new Point(18, 168);
            employeeInformationDataGrid.MultiSelect = false;
            employeeInformationDataGrid.Name = "employeeInformationDataGrid";
            employeeInformationDataGrid.ReadOnly = true;
            employeeInformationDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            employeeInformationDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            employeeInformationDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SkyBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.NullValue = "No data in this Cell";
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            employeeInformationDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            employeeInformationDataGrid.RowTemplate.Height = 30;
            employeeInformationDataGrid.ScrollBars = ScrollBars.Horizontal;
            employeeInformationDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeInformationDataGrid.ShowCellErrors = false;
            employeeInformationDataGrid.ShowCellToolTips = false;
            employeeInformationDataGrid.ShowEditingIcon = false;
            employeeInformationDataGrid.ShowRowErrors = false;
            employeeInformationDataGrid.Size = new Size(1118, 493);
            employeeInformationDataGrid.TabIndex = 7;
            employeeInformationDataGrid.CellClick += employeeInformationDataGrid_CellClick;
            // 
            // numberOfEmployeesLabel
            // 
            numberOfEmployeesLabel.AutoSize = true;
            numberOfEmployeesLabel.BackColor = Color.Transparent;
            numberOfEmployeesLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfEmployeesLabel.Location = new Point(908, 145);
            numberOfEmployeesLabel.Name = "numberOfEmployeesLabel";
            numberOfEmployeesLabel.Size = new Size(165, 20);
            numberOfEmployeesLabel.TabIndex = 7;
            numberOfEmployeesLabel.Text = "Number of Employees:";
            // 
            // genderInput
            // 
            genderInput.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderInput.FormattingEnabled = true;
            genderInput.Items.AddRange(new object[] { "Male", "Female" });
            genderInput.Location = new Point(699, 72);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(200, 25);
            genderInput.TabIndex = 6;
            genderInput.Text = "Gender";
            // 
            // manageEmployeesTitleHead
            // 
            manageEmployeesTitleHead.AutoSize = true;
            manageEmployeesTitleHead.BackColor = Color.Transparent;
            manageEmployeesTitleHead.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageEmployeesTitleHead.ForeColor = Color.White;
            manageEmployeesTitleHead.Location = new Point(185, 6);
            manageEmployeesTitleHead.Name = "manageEmployeesTitleHead";
            manageEmployeesTitleHead.Size = new Size(219, 31);
            manageEmployeesTitleHead.TabIndex = 2;
            manageEmployeesTitleHead.Text = "Manage Employees";
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Employees";
            Text = "Garage Managment System(GSM)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            EmployeeTable.ResumeLayout(false);
            EmployeeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeInformationDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label employeePasswordInputLable;
        private Label employeeAddressInputLable;
        private Label employeeNameInputLable;
        private MaskedTextBox employeePasswordInput;
        private MaskedTextBox employeeAddressInput;
        private Label employeeInformationLableHead;
        private MaskedTextBox employeeNameInput;
        private Panel panel1;
        private Panel EmployeeTable;
        private Label manageEmployeesTitleHead;
        private ComboBox genderInput;
        private DataGridView employeeInformationDataGrid;
        private Label numberOfEmployees;
        private Label numberOfEmployeesLabel;
    }
}