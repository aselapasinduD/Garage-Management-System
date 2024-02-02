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
            components = new System.ComponentModel.Container();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            employeeNameInput = new MaskedTextBox();
            panel1 = new Panel();
            carServicingTable = new Panel();
            genderBox = new ComboBox();
            carInformationTablePanel = new Panel();
            manageEmployeesTitleHead = new Label();
            menuPanel = new Panel();
            logoutMenuLable = new Label();
            analyticsMenuLable = new Label();
            billingMenuLable = new Label();
            employeesMenuLable = new Label();
            stockMenuLable = new Label();
            carMenuLable = new Label();
            carPictureLogo = new PictureBox();
            panel1.SuspendLayout();
            carServicingTable.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).BeginInit();
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            panel1.Controls.Add(carServicingTable);
            panel1.Controls.Add(manageEmployeesTitleHead);
            panel1.Controls.Add(menuPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 2;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.BackColor = Color.DarkGray;
            carServicingTable.Controls.Add(genderBox);
            carServicingTable.Controls.Add(carInformationTablePanel);
            carServicingTable.Controls.Add(deleteButton);
            carServicingTable.Controls.Add(editButton);
            carServicingTable.Controls.Add(addButton);
            carServicingTable.Controls.Add(employeePasswordInputLable);
            carServicingTable.Controls.Add(employeeAddressInputLable);
            carServicingTable.Controls.Add(employeeNameInputLable);
            carServicingTable.Controls.Add(employeePasswordInput);
            carServicingTable.Controls.Add(employeeAddressInput);
            carServicingTable.Controls.Add(employeeNameInput);
            carServicingTable.Controls.Add(employeeInformationLableHead);
            carServicingTable.Location = new Point(185, 40);
            carServicingTable.Margin = new Padding(8);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1154, 677);
            carServicingTable.TabIndex = 3;
            // 
            // genderBox
            // 
            genderBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(699, 72);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(200, 25);
            genderBox.TabIndex = 6;
            genderBox.Text = "Gender";
            // 
            // carInformationTablePanel
            // 
            carInformationTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carInformationTablePanel.BackColor = Color.White;
            carInformationTablePanel.Location = new Point(18, 170);
            carInformationTablePanel.Margin = new Padding(8);
            carInformationTablePanel.Name = "carInformationTablePanel";
            carInformationTablePanel.Size = new Size(1118, 491);
            carInformationTablePanel.TabIndex = 5;
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
            // menuPanel
            // 
            menuPanel.BackColor = Color.Gray;
            menuPanel.Controls.Add(logoutMenuLable);
            menuPanel.Controls.Add(analyticsMenuLable);
            menuPanel.Controls.Add(billingMenuLable);
            menuPanel.Controls.Add(employeesMenuLable);
            menuPanel.Controls.Add(stockMenuLable);
            menuPanel.Controls.Add(carMenuLable);
            menuPanel.Controls.Add(carPictureLogo);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(169, 729);
            menuPanel.TabIndex = 0;
            // 
            // logoutMenuLable
            // 
            logoutMenuLable.AutoSize = true;
            logoutMenuLable.BackColor = Color.Transparent;
            logoutMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutMenuLable.ForeColor = Color.White;
            logoutMenuLable.Location = new Point(41, 410);
            logoutMenuLable.Name = "logoutMenuLable";
            logoutMenuLable.Size = new Size(82, 30);
            logoutMenuLable.TabIndex = 2;
            logoutMenuLable.Text = "Logout";
            // 
            // analyticsMenuLable
            // 
            analyticsMenuLable.BackColor = Color.Transparent;
            analyticsMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            analyticsMenuLable.ForeColor = Color.White;
            analyticsMenuLable.Location = new Point(15, 352);
            analyticsMenuLable.Name = "analyticsMenuLable";
            analyticsMenuLable.Size = new Size(154, 30);
            analyticsMenuLable.TabIndex = 2;
            analyticsMenuLable.Text = "Analytics";
            // 
            // billingMenuLable
            // 
            billingMenuLable.BackColor = Color.Transparent;
            billingMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingMenuLable.ForeColor = Color.White;
            billingMenuLable.Location = new Point(15, 298);
            billingMenuLable.Name = "billingMenuLable";
            billingMenuLable.Size = new Size(154, 30);
            billingMenuLable.TabIndex = 2;
            billingMenuLable.Text = "Billing";
            // 
            // employeesMenuLable
            // 
            employeesMenuLable.BackColor = Color.Black;
            employeesMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesMenuLable.ForeColor = Color.White;
            employeesMenuLable.Location = new Point(15, 244);
            employeesMenuLable.Name = "employeesMenuLable";
            employeesMenuLable.Size = new Size(154, 30);
            employeesMenuLable.TabIndex = 2;
            employeesMenuLable.Text = "Employees";
            // 
            // stockMenuLable
            // 
            stockMenuLable.BackColor = Color.Transparent;
            stockMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockMenuLable.ForeColor = Color.White;
            stockMenuLable.Location = new Point(15, 190);
            stockMenuLable.Name = "stockMenuLable";
            stockMenuLable.Size = new Size(154, 30);
            stockMenuLable.TabIndex = 2;
            stockMenuLable.Text = "Stock";
            // 
            // carMenuLable
            // 
            carMenuLable.BackColor = Color.Transparent;
            carMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carMenuLable.ForeColor = Color.White;
            carMenuLable.Location = new Point(15, 140);
            carMenuLable.Name = "carMenuLable";
            carMenuLable.Size = new Size(154, 30);
            carMenuLable.TabIndex = 0;
            carMenuLable.Text = "Cars";
            // 
            // carPictureLogo
            // 
            carPictureLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            carPictureLogo.Image = (Image)resources.GetObject("carPictureLogo.Image");
            carPictureLogo.Location = new Point(3, 0);
            carPictureLogo.Name = "carPictureLogo";
            carPictureLogo.Size = new Size(163, 99);
            carPictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            carPictureLogo.TabIndex = 1;
            carPictureLogo.TabStop = false;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            MinimumSize = new Size(1366, 768);
            Name = "Employees";
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            carServicingTable.ResumeLayout(false);
            carServicingTable.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).EndInit();
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
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox employeeNameInput;
        private Panel panel1;
        private Panel carServicingTable;
        private Panel carInformationTablePanel;
        private Label manageEmployeesTitleHead;
        private Panel menuPanel;
        private Label logoutMenuLable;
        private Label analyticsMenuLable;
        private Label billingMenuLable;
        private Label employeesMenuLable;
        private Label stockMenuLable;
        private Label carMenuLable;
        private PictureBox carPictureLogo;
        private ComboBox genderBox;
    }
}