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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            carPanel = new Panel();
            carServicingTable = new Panel();
            numberOfCars = new Label();
            numberOfCarLabel = new Label();
            carInformationDataGrid = new DataGridView();
            carInformationDate = new DateTimePicker();
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
            carPanel.SuspendLayout();
            carServicingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carInformationDataGrid).BeginInit();
            SuspendLayout();
            // 
            // carPanel
            // 
            carPanel.BackColor = Color.Black;
            carPanel.Controls.Add(carServicingTable);
            carPanel.Controls.Add(carServicingTitleHead);
            carPanel.Dock = DockStyle.Fill;
            carPanel.Location = new Point(0, 0);
            carPanel.Name = "carPanel";
            carPanel.Size = new Size(1350, 729);
            carPanel.TabIndex = 0;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.BackColor = Color.DarkGray;
            carServicingTable.Controls.Add(numberOfCars);
            carServicingTable.Controls.Add(numberOfCarLabel);
            carServicingTable.Controls.Add(carInformationDataGrid);
            carServicingTable.Controls.Add(carInformationDate);
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
            // numberOfCars
            // 
            numberOfCars.AutoSize = true;
            numberOfCars.BackColor = Color.Transparent;
            numberOfCars.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfCars.Location = new Point(1098, 184);
            numberOfCars.Name = "numberOfCars";
            numberOfCars.Size = new Size(17, 20);
            numberOfCars.TabIndex = 6;
            numberOfCars.Text = "0";
            // 
            // numberOfCarLabel
            // 
            numberOfCarLabel.AutoSize = true;
            numberOfCarLabel.BackColor = Color.Transparent;
            numberOfCarLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfCarLabel.Location = new Point(971, 184);
            numberOfCarLabel.Name = "numberOfCarLabel";
            numberOfCarLabel.Size = new Size(121, 20);
            numberOfCarLabel.TabIndex = 5;
            numberOfCarLabel.Text = "Number of Cars:";
            // 
            // carInformationDataGrid
            // 
            carInformationDataGrid.AllowUserToAddRows = false;
            carInformationDataGrid.AllowUserToDeleteRows = false;
            carInformationDataGrid.AllowUserToResizeColumns = false;
            carInformationDataGrid.AllowUserToResizeRows = false;
            carInformationDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            carInformationDataGrid.BackgroundColor = Color.White;
            carInformationDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            carInformationDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            carInformationDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            carInformationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            carInformationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            carInformationDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            carInformationDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            carInformationDataGrid.GridColor = Color.Black;
            carInformationDataGrid.ImeMode = ImeMode.Off;
            carInformationDataGrid.Location = new Point(18, 207);
            carInformationDataGrid.MultiSelect = false;
            carInformationDataGrid.Name = "carInformationDataGrid";
            carInformationDataGrid.ReadOnly = true;
            carInformationDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            carInformationDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            carInformationDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.SkyBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.NullValue = "No data in this Cell";
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            carInformationDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            carInformationDataGrid.RowTemplate.Height = 30;
            carInformationDataGrid.ScrollBars = ScrollBars.Horizontal;
            carInformationDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            carInformationDataGrid.ShowCellErrors = false;
            carInformationDataGrid.ShowCellToolTips = false;
            carInformationDataGrid.ShowEditingIcon = false;
            carInformationDataGrid.ShowRowErrors = false;
            carInformationDataGrid.Size = new Size(1118, 454);
            carInformationDataGrid.TabIndex = 0;
            carInformationDataGrid.CellClick += carInformationDataGrid_CellContentClick;
            // 
            // carInformationDate
            // 
            carInformationDate.CustomFormat = "";
            carInformationDate.Location = new Point(18, 53);
            carInformationDate.Name = "carInformationDate";
            carInformationDate.Size = new Size(200, 23);
            carInformationDate.TabIndex = 4;
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
            // 
            // carColorInput
            // 
            carColorInput.Font = new Font("Segoe UI", 10F);
            carColorInput.Location = new Point(699, 115);
            carColorInput.Name = "carColorInput";
            carColorInput.Size = new Size(200, 25);
            carColorInput.TabIndex = 1;
            // 
            // carModelInput
            // 
            carModelInput.Font = new Font("Segoe UI", 10F);
            carModelInput.Location = new Point(472, 115);
            carModelInput.Name = "carModelInput";
            carModelInput.Size = new Size(200, 25);
            carModelInput.TabIndex = 1;
            // 
            // carBrandInput
            // 
            carBrandInput.Font = new Font("Segoe UI", 10F);
            carBrandInput.Location = new Point(245, 115);
            carBrandInput.Name = "carBrandInput";
            carBrandInput.Size = new Size(200, 25);
            carBrandInput.TabIndex = 1;
            // 
            // carNumberInput
            // 
            carNumberInput.AsciiOnly = true;
            carNumberInput.Font = new Font("Segoe UI", 10F);
            carNumberInput.HidePromptOnLeave = true;
            carNumberInput.Location = new Point(18, 115);
            carNumberInput.Mask = ">AAAAAAAAAA";
            carNumberInput.Name = "carNumberInput";
            carNumberInput.Size = new Size(200, 25);
            carNumberInput.TabIndex = 1;
            carNumberInput.ValidatingType = typeof(int);
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
            // Cars
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(carPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cars";
            Text = "Garage Managment System(GSM)";
            carPanel.ResumeLayout(false);
            carPanel.PerformLayout();
            carServicingTable.ResumeLayout(false);
            carServicingTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carInformationDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel carPanel;
        private Label carServicingTitleHead;
        private Panel carServicingTable;
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
        private DateTimePicker carInformationDate;
        private DataGridView carInformationDataGrid;
        private Label numberOfCars;
        private Label numberOfCarLabel;
    }
}
