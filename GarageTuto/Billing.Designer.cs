namespace GarageTuto
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            menuPanel = new Panel();
            logoutMenuLable = new Label();
            analyticsMenuLable = new Label();
            billingMenuLable = new Label();
            employeesMenuLable = new Label();
            stockMenuLable = new Label();
            carMenuLable = new Label();
            carPictureLogo = new PictureBox();
            calculateFeeButton = new Button();
            printButton = new Button();
            addPartButton = new Button();
            dateInputLable = new Label();
            carNumberBoxLable = new Label();
            mechanicsFeeInputLable = new Label();
            quantityInputLable = new Label();
            billingInformationLableHead = new Label();
            panel1 = new Panel();
            carServicingTable = new Panel();
            carDateShowingLabel = new Label();
            carOwnerNameShowLabel = new Label();
            dateLabel = new Label();
            carOwnerLabel = new Label();
            totalPriceNumber = new Label();
            totalPriceLabel = new Label();
            billingDataGrid = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Part = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            stockLabel = new Label();
            carNumberBox = new ComboBox();
            stockDataGrid = new DataGridView();
            billingDatePicker = new DateTimePicker();
            mechanicsFeeInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            billingTitleHead = new Label();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).BeginInit();
            panel1.SuspendLayout();
            carServicingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billingDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockDataGrid).BeginInit();
            SuspendLayout();
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
            billingMenuLable.BackColor = Color.Black;
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
            employeesMenuLable.BackColor = Color.Transparent;
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
            // calculateFeeButton
            // 
            calculateFeeButton.BackColor = Color.Salmon;
            calculateFeeButton.Cursor = Cursors.Hand;
            calculateFeeButton.Font = new Font("Segoe UI", 12F);
            calculateFeeButton.Location = new Point(505, 520);
            calculateFeeButton.Name = "calculateFeeButton";
            calculateFeeButton.Size = new Size(145, 33);
            calculateFeeButton.TabIndex = 3;
            calculateFeeButton.Text = "Calculate Fee";
            calculateFeeButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            printButton.BackColor = Color.PaleGreen;
            printButton.Cursor = Cursors.Hand;
            printButton.Font = new Font("Segoe UI", 12F);
            printButton.Location = new Point(848, 629);
            printButton.Name = "printButton";
            printButton.Size = new Size(145, 33);
            printButton.TabIndex = 3;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = false;
            // 
            // addPartButton
            // 
            addPartButton.BackColor = Color.SkyBlue;
            addPartButton.Cursor = Cursors.Hand;
            addPartButton.Font = new Font("Segoe UI", 12F);
            addPartButton.Location = new Point(505, 402);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(145, 33);
            addPartButton.TabIndex = 3;
            addPartButton.Text = "Add Part";
            addPartButton.UseVisualStyleBackColor = false;
            // 
            // dateInputLable
            // 
            dateInputLable.AutoSize = true;
            dateInputLable.Font = new Font("Segoe UI", 12F);
            dateInputLable.Location = new Point(463, 231);
            dateInputLable.Name = "dateInputLable";
            dateInputLable.Size = new Size(42, 21);
            dateInputLable.TabIndex = 2;
            dateInputLable.Text = "Date";
            // 
            // carNumberBoxLable
            // 
            carNumberBoxLable.AutoSize = true;
            carNumberBoxLable.Font = new Font("Segoe UI", 12F);
            carNumberBoxLable.Location = new Point(463, 68);
            carNumberBoxLable.Name = "carNumberBoxLable";
            carNumberBoxLable.Size = new Size(96, 21);
            carNumberBoxLable.TabIndex = 2;
            carNumberBoxLable.Text = "Car Number";
            // 
            // mechanicsFeeInputLable
            // 
            mechanicsFeeInputLable.AutoSize = true;
            mechanicsFeeInputLable.Font = new Font("Segoe UI", 12F);
            mechanicsFeeInputLable.Location = new Point(463, 456);
            mechanicsFeeInputLable.Name = "mechanicsFeeInputLable";
            mechanicsFeeInputLable.Size = new Size(111, 21);
            mechanicsFeeInputLable.TabIndex = 2;
            mechanicsFeeInputLable.Text = "Mechanics Fee";
            // 
            // quantityInputLable
            // 
            quantityInputLable.AutoSize = true;
            quantityInputLable.Font = new Font("Segoe UI", 12F);
            quantityInputLable.Location = new Point(463, 338);
            quantityInputLable.Name = "quantityInputLable";
            quantityInputLable.Size = new Size(70, 21);
            quantityInputLable.TabIndex = 2;
            quantityInputLable.Text = "Quantity";
            // 
            // billingInformationLableHead
            // 
            billingInformationLableHead.AutoSize = true;
            billingInformationLableHead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            billingInformationLableHead.ForeColor = Color.White;
            billingInformationLableHead.Location = new Point(3, 12);
            billingInformationLableHead.Name = "billingInformationLableHead";
            billingInformationLableHead.Size = new Size(200, 30);
            billingInformationLableHead.TabIndex = 0;
            billingInformationLableHead.Text = "Billing Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(carServicingTable);
            panel1.Controls.Add(billingTitleHead);
            panel1.Controls.Add(menuPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 1;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.BackColor = Color.DarkGray;
            carServicingTable.Controls.Add(carDateShowingLabel);
            carServicingTable.Controls.Add(carOwnerNameShowLabel);
            carServicingTable.Controls.Add(dateLabel);
            carServicingTable.Controls.Add(carOwnerLabel);
            carServicingTable.Controls.Add(totalPriceNumber);
            carServicingTable.Controls.Add(totalPriceLabel);
            carServicingTable.Controls.Add(billingDataGrid);
            carServicingTable.Controls.Add(stockLabel);
            carServicingTable.Controls.Add(carNumberBox);
            carServicingTable.Controls.Add(stockDataGrid);
            carServicingTable.Controls.Add(billingDatePicker);
            carServicingTable.Controls.Add(calculateFeeButton);
            carServicingTable.Controls.Add(printButton);
            carServicingTable.Controls.Add(addPartButton);
            carServicingTable.Controls.Add(dateInputLable);
            carServicingTable.Controls.Add(carNumberBoxLable);
            carServicingTable.Controls.Add(mechanicsFeeInputLable);
            carServicingTable.Controls.Add(quantityInputLable);
            carServicingTable.Controls.Add(mechanicsFeeInput);
            carServicingTable.Controls.Add(quantityInput);
            carServicingTable.Controls.Add(billingInformationLableHead);
            carServicingTable.Location = new Point(185, 40);
            carServicingTable.Margin = new Padding(8);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1154, 677);
            carServicingTable.TabIndex = 3;
            // 
            // carDateShowingLabel
            // 
            carDateShowingLabel.AutoSize = true;
            carDateShowingLabel.BackColor = Color.Transparent;
            carDateShowingLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carDateShowingLabel.Location = new Point(546, 161);
            carDateShowingLabel.Name = "carDateShowingLabel";
            carDateShowingLabel.Size = new Size(49, 17);
            carDateShowingLabel.TabIndex = 15;
            carDateShowingLabel.Text = "Testing";
            // 
            // carOwnerNameShowLabel
            // 
            carOwnerNameShowLabel.AutoSize = true;
            carOwnerNameShowLabel.BackColor = Color.Transparent;
            carOwnerNameShowLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carOwnerNameShowLabel.Location = new Point(546, 134);
            carOwnerNameShowLabel.Name = "carOwnerNameShowLabel";
            carOwnerNameShowLabel.Size = new Size(49, 17);
            carOwnerNameShowLabel.TabIndex = 14;
            carOwnerNameShowLabel.Text = "Testing";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(463, 161);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(42, 17);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Date :";
            // 
            // carOwnerLabel
            // 
            carOwnerLabel.AutoSize = true;
            carOwnerLabel.BackColor = Color.Transparent;
            carOwnerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carOwnerLabel.Location = new Point(463, 134);
            carOwnerLabel.Name = "carOwnerLabel";
            carOwnerLabel.Size = new Size(77, 17);
            carOwnerLabel.TabIndex = 12;
            carOwnerLabel.Text = "Car Owner :";
            // 
            // totalPriceNumber
            // 
            totalPriceNumber.AutoSize = true;
            totalPriceNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceNumber.Location = new Point(1029, 592);
            totalPriceNumber.Name = "totalPriceNumber";
            totalPriceNumber.Size = new Size(54, 25);
            totalPriceNumber.TabIndex = 10;
            totalPriceNumber.Text = "Price";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(729, 592);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(105, 25);
            totalPriceLabel.TabIndex = 8;
            totalPriceLabel.Text = "Total Price:";
            // 
            // billingDataGrid
            // 
            billingDataGrid.AllowUserToAddRows = false;
            billingDataGrid.AllowUserToDeleteRows = false;
            billingDataGrid.AllowUserToResizeColumns = false;
            billingDataGrid.AllowUserToResizeRows = false;
            billingDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            billingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billingDataGrid.BackgroundColor = Color.White;
            billingDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            billingDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            billingDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = Color.Black;
            dataGridViewCellStyle41.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle41.ForeColor = Color.White;
            dataGridViewCellStyle41.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = DataGridViewTriState.True;
            billingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            billingDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billingDataGrid.Columns.AddRange(new DataGridViewColumn[] { Number, Part, Price, Quantity, Total });
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = Color.Black;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle42.ForeColor = Color.White;
            dataGridViewCellStyle42.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.True;
            billingDataGrid.DefaultCellStyle = dataGridViewCellStyle42;
            billingDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            billingDataGrid.GridColor = Color.Black;
            billingDataGrid.ImeMode = ImeMode.Off;
            billingDataGrid.Location = new Point(704, 70);
            billingDataGrid.MultiSelect = false;
            billingDataGrid.Name = "billingDataGrid";
            billingDataGrid.ReadOnly = true;
            billingDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            billingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            billingDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = Color.SkyBlue;
            dataGridViewCellStyle44.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle44.ForeColor = Color.Black;
            dataGridViewCellStyle44.NullValue = "No data in this Cell";
            dataGridViewCellStyle44.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = SystemColors.HighlightText;
            billingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle44;
            billingDataGrid.RowTemplate.Height = 30;
            billingDataGrid.ScrollBars = ScrollBars.Horizontal;
            billingDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billingDataGrid.ShowCellErrors = false;
            billingDataGrid.ShowCellToolTips = false;
            billingDataGrid.ShowEditingIcon = false;
            billingDataGrid.ShowRowErrors = false;
            billingDataGrid.Size = new Size(432, 506);
            billingDataGrid.TabIndex = 7;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            // 
            // Part
            // 
            Part.HeaderText = "Part";
            Part.Name = "Part";
            Part.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.BackColor = Color.Transparent;
            stockLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockLabel.Location = new Point(205, 44);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(58, 25);
            stockLabel.TabIndex = 6;
            stockLabel.Text = "Stock";
            // 
            // carNumberBox
            // 
            carNumberBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carNumberBox.FormattingEnabled = true;
            carNumberBox.Location = new Point(463, 92);
            carNumberBox.Name = "carNumberBox";
            carNumberBox.Size = new Size(228, 29);
            carNumberBox.TabIndex = 2;
            // 
            // stockDataGrid
            // 
            stockDataGrid.AllowUserToAddRows = false;
            stockDataGrid.AllowUserToDeleteRows = false;
            stockDataGrid.AllowUserToResizeColumns = false;
            stockDataGrid.AllowUserToResizeRows = false;
            stockDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockDataGrid.BackgroundColor = Color.White;
            stockDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            stockDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            stockDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = Color.Black;
            dataGridViewCellStyle45.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle45.ForeColor = Color.White;
            dataGridViewCellStyle45.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = DataGridViewTriState.True;
            stockDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            stockDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = Color.Black;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle46.ForeColor = Color.White;
            dataGridViewCellStyle46.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = DataGridViewTriState.True;
            stockDataGrid.DefaultCellStyle = dataGridViewCellStyle46;
            stockDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            stockDataGrid.GridColor = Color.Black;
            stockDataGrid.ImeMode = ImeMode.Off;
            stockDataGrid.Location = new Point(18, 70);
            stockDataGrid.MultiSelect = false;
            stockDataGrid.Name = "stockDataGrid";
            stockDataGrid.ReadOnly = true;
            stockDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            stockDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            stockDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = Color.SkyBlue;
            dataGridViewCellStyle48.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle48.ForeColor = Color.Black;
            dataGridViewCellStyle48.NullValue = "No data in this Cell";
            dataGridViewCellStyle48.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
            stockDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle48;
            stockDataGrid.RowTemplate.Height = 30;
            stockDataGrid.ScrollBars = ScrollBars.Horizontal;
            stockDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockDataGrid.ShowCellErrors = false;
            stockDataGrid.ShowCellToolTips = false;
            stockDataGrid.ShowEditingIcon = false;
            stockDataGrid.ShowRowErrors = false;
            stockDataGrid.Size = new Size(432, 506);
            stockDataGrid.TabIndex = 5;
            // 
            // billingDatePicker
            // 
            billingDatePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingDatePicker.Location = new Point(463, 255);
            billingDatePicker.Name = "billingDatePicker";
            billingDatePicker.Size = new Size(228, 25);
            billingDatePicker.TabIndex = 4;
            // 
            // mechanicsFeeInput
            // 
            mechanicsFeeInput.AllowPromptAsInput = false;
            mechanicsFeeInput.Font = new Font("Segoe UI", 10F);
            mechanicsFeeInput.HidePromptOnLeave = true;
            mechanicsFeeInput.Location = new Point(463, 480);
            mechanicsFeeInput.Mask = "0000000000";
            mechanicsFeeInput.Name = "mechanicsFeeInput";
            mechanicsFeeInput.Size = new Size(228, 25);
            mechanicsFeeInput.TabIndex = 1;
            mechanicsFeeInput.ValidatingType = typeof(int);
            // 
            // quantityInput
            // 
            quantityInput.AllowPromptAsInput = false;
            quantityInput.Font = new Font("Segoe UI", 10F);
            quantityInput.HidePromptOnLeave = true;
            quantityInput.Location = new Point(463, 362);
            quantityInput.Mask = "00000";
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(228, 25);
            quantityInput.TabIndex = 1;
            quantityInput.ValidatingType = typeof(int);
            // 
            // billingTitleHead
            // 
            billingTitleHead.AutoSize = true;
            billingTitleHead.BackColor = Color.Transparent;
            billingTitleHead.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            billingTitleHead.ForeColor = Color.White;
            billingTitleHead.Location = new Point(185, 6);
            billingTitleHead.Name = "billingTitleHead";
            billingTitleHead.Size = new Size(82, 31);
            billingTitleHead.TabIndex = 2;
            billingTitleHead.Text = "Billing";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "Billing";
            Text = "Garage Managment System(GSM)";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            carServicingTable.ResumeLayout(false);
            carServicingTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billingDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPanel;
        private Label logoutMenuLable;
        private Label analyticsMenuLable;
        private Label billingMenuLable;
        private Label employeesMenuLable;
        private Label stockMenuLable;
        private Label carMenuLable;
        private PictureBox carPictureLogo;
        private Button calculateFeeButton;
        private Button printButton;
        private Button addPartButton;
        private Label dateInputLable;
        private Label carNumberBoxLable;
        private Label mechanicsFeeInputLable;
        private Label quantityInputLable;
        private Label billingInformationLableHead;
        private Panel panel1;
        private Panel carServicingTable;
        private Label billingTitleHead;
        private Label stockLabel;
        private DataGridView billingDataGrid;
        private ComboBox carNumberBox;
        private DataGridView stockDataGrid;
        private DateTimePicker billingDatePicker;
        private MaskedTextBox mechanicsFeeInput;
        private MaskedTextBox quantityInput;
        private Label totalPriceNumber;
        private Label totalPriceLabel;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Part;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label carOwnerLabel;
        private Label carDateShowingLabel;
        private Label carOwnerNameShowLabel;
        private Label dateLabel;
    }
}