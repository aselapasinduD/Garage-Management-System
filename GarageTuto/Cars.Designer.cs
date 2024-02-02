﻿namespace GarageTuto
{
    partial class Cars
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            panel1 = new Panel();
            carServicingTable = new Panel();
            carInformationTablePanel = new Panel();
            carInforamationDatePicker = new DateTimePicker();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            ownerNameInputLable = new Label();
            carColorInputLable = new Label();
            carModelInputLable = new Label();
            carBrandInputLable = new Label();
            carNumberInputLable = new Label();
            ownerNameInput = new MaskedTextBox();
            carColorInput = new MaskedTextBox();
            carModelInput = new MaskedTextBox();
            carBrandInput = new MaskedTextBox();
            carNumberInput = new MaskedTextBox();
            carInformationLableHead = new Label();
            carServicingTitleHead = new Label();
            menuPanel = new Panel();
            logoutMenuLable = new Label();
            analyticsMenuLable = new Label();
            billingMenuLable = new Label();
            employeesMenuLable = new Label();
            stockMenuLable = new Label();
            carMenuLable = new Label();
            carPictureLogo = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            carServicingTable.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(carServicingTable);
            panel1.Controls.Add(carServicingTitleHead);
            panel1.Controls.Add(menuPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 0;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.BackColor = Color.DarkGray;
            carServicingTable.Controls.Add(carInformationTablePanel);
            carServicingTable.Controls.Add(carInforamationDatePicker);
            carServicingTable.Controls.Add(deleteButton);
            carServicingTable.Controls.Add(editButton);
            carServicingTable.Controls.Add(addButton);
            carServicingTable.Controls.Add(ownerNameInputLable);
            carServicingTable.Controls.Add(carColorInputLable);
            carServicingTable.Controls.Add(carModelInputLable);
            carServicingTable.Controls.Add(carBrandInputLable);
            carServicingTable.Controls.Add(carNumberInputLable);
            carServicingTable.Controls.Add(ownerNameInput);
            carServicingTable.Controls.Add(carColorInput);
            carServicingTable.Controls.Add(carModelInput);
            carServicingTable.Controls.Add(carBrandInput);
            carServicingTable.Controls.Add(carNumberInput);
            carServicingTable.Controls.Add(carInformationLableHead);
            carServicingTable.Location = new Point(185, 40);
            carServicingTable.Margin = new Padding(8);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1154, 677);
            carServicingTable.TabIndex = 3;
            // 
            // carInformationTablePanel
            // 
            carInformationTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carInformationTablePanel.BackColor = Color.White;
            carInformationTablePanel.Location = new Point(18, 207);
            carInformationTablePanel.Margin = new Padding(8);
            carInformationTablePanel.Name = "carInformationTablePanel";
            carInformationTablePanel.Size = new Size(1118, 454);
            carInformationTablePanel.TabIndex = 5;
            // 
            // carInforamationDatePicker
            // 
            carInforamationDatePicker.Location = new Point(18, 53);
            carInforamationDatePicker.Name = "carInforamationDatePicker";
            carInforamationDatePicker.Size = new Size(200, 23);
            carInforamationDatePicker.TabIndex = 4;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Salmon;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Segoe UI", 12F);
            deleteButton.Location = new Point(368, 157);
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
            editButton.Location = new Point(193, 157);
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
            addButton.Location = new Point(18, 157);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 33);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // ownerNameInputLable
            // 
            ownerNameInputLable.AutoSize = true;
            ownerNameInputLable.Font = new Font("Segoe UI", 12F);
            ownerNameInputLable.Location = new Point(926, 91);
            ownerNameInputLable.Name = "ownerNameInputLable";
            ownerNameInputLable.Size = new Size(103, 21);
            ownerNameInputLable.TabIndex = 2;
            ownerNameInputLable.Text = "Owner Name";
            // 
            // carColorInputLable
            // 
            carColorInputLable.AutoSize = true;
            carColorInputLable.Font = new Font("Segoe UI", 12F);
            carColorInputLable.Location = new Point(699, 91);
            carColorInputLable.Name = "carColorInputLable";
            carColorInputLable.Size = new Size(76, 21);
            carColorInputLable.TabIndex = 2;
            carColorInputLable.Text = "Car Color";
            // 
            // carModelInputLable
            // 
            carModelInputLable.AutoSize = true;
            carModelInputLable.Font = new Font("Segoe UI", 12F);
            carModelInputLable.Location = new Point(472, 91);
            carModelInputLable.Name = "carModelInputLable";
            carModelInputLable.Size = new Size(82, 21);
            carModelInputLable.TabIndex = 2;
            carModelInputLable.Text = "Car Model";
            // 
            // carBrandInputLable
            // 
            carBrandInputLable.AutoSize = true;
            carBrandInputLable.Font = new Font("Segoe UI", 12F);
            carBrandInputLable.Location = new Point(245, 91);
            carBrandInputLable.Name = "carBrandInputLable";
            carBrandInputLable.Size = new Size(79, 21);
            carBrandInputLable.TabIndex = 2;
            carBrandInputLable.Text = "Car Brand";
            // 
            // carNumberInputLable
            // 
            carNumberInputLable.AutoSize = true;
            carNumberInputLable.Font = new Font("Segoe UI", 12F);
            carNumberInputLable.Location = new Point(18, 91);
            carNumberInputLable.Name = "carNumberInputLable";
            carNumberInputLable.Size = new Size(96, 21);
            carNumberInputLable.TabIndex = 2;
            carNumberInputLable.Text = "Car Number";
            // 
            // ownerNameInput
            // 
            ownerNameInput.Font = new Font("Segoe UI", 10F);
            ownerNameInput.Location = new Point(926, 115);
            ownerNameInput.Name = "ownerNameInput";
            ownerNameInput.Size = new Size(200, 25);
            ownerNameInput.TabIndex = 1;
            ownerNameInput.MaskInputRejected += ownerNameInput_MaskInputRejected;
            // 
            // carColorInput
            // 
            carColorInput.Font = new Font("Segoe UI", 10F);
            carColorInput.Location = new Point(699, 115);
            carColorInput.Name = "carColorInput";
            carColorInput.Size = new Size(200, 25);
            carColorInput.TabIndex = 1;
            carColorInput.MaskInputRejected += carColorInput_MaskInputRejected;
            // 
            // carModelInput
            // 
            carModelInput.Font = new Font("Segoe UI", 10F);
            carModelInput.Location = new Point(472, 115);
            carModelInput.Name = "carModelInput";
            carModelInput.Size = new Size(200, 25);
            carModelInput.TabIndex = 1;
            carModelInput.MaskInputRejected += carModelInput_MaskInputRejected;
            // 
            // carBrandInput
            // 
            carBrandInput.Font = new Font("Segoe UI", 10F);
            carBrandInput.Location = new Point(245, 115);
            carBrandInput.Name = "carBrandInput";
            carBrandInput.Size = new Size(200, 25);
            carBrandInput.TabIndex = 1;
            carBrandInput.MaskInputRejected += carBrandInput_MaskInputRejected;
            // 
            // carNumberInput
            // 
            carNumberInput.Font = new Font("Segoe UI", 10F);
            carNumberInput.Location = new Point(18, 115);
            carNumberInput.Name = "carNumberInput";
            carNumberInput.Size = new Size(200, 25);
            carNumberInput.TabIndex = 1;
            carNumberInput.MaskInputRejected += carNumberInput_MaskInputRejected;
            // 
            // carInformationLableHead
            // 
            carInformationLableHead.AutoSize = true;
            carInformationLableHead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            carInformationLableHead.ForeColor = Color.White;
            carInformationLableHead.Location = new Point(3, 12);
            carInformationLableHead.Name = "carInformationLableHead";
            carInformationLableHead.Size = new Size(170, 30);
            carInformationLableHead.TabIndex = 0;
            carInformationLableHead.Text = "Car Information";
            // 
            // carServicingTitleHead
            // 
            carServicingTitleHead.AutoSize = true;
            carServicingTitleHead.BackColor = Color.Transparent;
            carServicingTitleHead.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carServicingTitleHead.ForeColor = Color.White;
            carServicingTitleHead.Location = new Point(185, 6);
            carServicingTitleHead.Name = "carServicingTitleHead";
            carServicingTitleHead.Size = new Size(288, 31);
            carServicingTitleHead.TabIndex = 2;
            carServicingTitleHead.Text = "Record Cars for Servicing";
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
            logoutMenuLable.Click += logoutMenuLable_Click;
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
            analyticsMenuLable.Click += analyticsMenuLable_Click;
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
            billingMenuLable.Click += billingMenuLable_Click;
            // 
            // employeesMenuLable
            // 
            employeesMenuLable.BackColor = Color.Transparent;
            employeesMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesMenuLable.ForeColor = Color.White;
            employeesMenuLable.Location = new Point(15, 244);
            employeesMenuLable.Name = "employeesMenuLable";
            employeesMenuLable.Size = new Size(154, 30);
            employeesMenuLable.TabIndex = 2;
            employeesMenuLable.Text = "Employees";
            employeesMenuLable.Click += employeesMenuLable_Click;
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
            stockMenuLable.Click += stockMenuLable_Click;
            // 
            // carMenuLable
            // 
            carMenuLable.BackColor = Color.Black;
            carMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carMenuLable.ForeColor = Color.White;
            carMenuLable.Location = new Point(15, 140);
            carMenuLable.Name = "carMenuLable";
            carMenuLable.Size = new Size(154, 30);
            carMenuLable.TabIndex = 0;
            carMenuLable.Text = "Cars";
            carMenuLable.Click += carMenuLable_Click;
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
            carPictureLogo.Click += carPictureLogo_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Cars
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "Cars";
            Text = "Garage Managment System(GSM)";
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

        private Panel panel1;
        private Panel menuPanel;
        private PictureBox carPictureLogo;
        private Label carServicingTitleHead;
        private Panel carServicingTable;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox carNumberInput;
        private Label carInformationLableHead;
        private Label carNumberInputLable;
        private Label ownerNameInputLable;
        private Label carColorInputLable;
        private Label carModelInputLable;
        private Label carBrandInputLable;
        private MaskedTextBox ownerNameInput;
        private MaskedTextBox carColorInput;
        private MaskedTextBox carModelInput;
        private MaskedTextBox carBrandInput;
        private Button addButton;
        private Button deleteButton;
        private Button editButton;
        private DateTimePicker carInforamationDatePicker;
        private Panel carInformationTablePanel;
        private Label carMenuLable;
        private Label analyticsMenuLable;
        private Label billingMenuLable;
        private Label employeesMenuLable;
        private Label stockMenuLable;
        private Label logoutMenuLable;
    }
}