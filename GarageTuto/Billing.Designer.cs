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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            removePartButton = new Button();
            printButton = new Button();
            addPartButton = new Button();
            dateInputLable = new Label();
            carNumberBoxLable = new Label();
            mechanicsFeeInputLable = new Label();
            quantityInputLable = new Label();
            billingInformationLableHead = new Label();
            panel1 = new Panel();
            employeeName = new Label();
            billingTable = new Panel();
            numberOfParts = new Label();
            numberOfPartsLabel = new Label();
            carDateShowingLabel = new Label();
            carOwnerNameShowLabel = new Label();
            dateLabel = new Label();
            carOwnerLabel = new Label();
            totalPriceNumber = new Label();
            totalPriceLabel = new Label();
            billingDataGrid = new DataGridView();
            numberTableHead = new DataGridViewTextBoxColumn();
            billingPartId = new DataGridViewTextBoxColumn();
            partsTableHead = new DataGridViewTextBoxColumn();
            quantityTableHead = new DataGridViewTextBoxColumn();
            priceTableHead = new DataGridViewTextBoxColumn();
            totalTableHead = new DataGridViewTextBoxColumn();
            stockLabel = new Label();
            carNumberBox = new ComboBox();
            stockDataGrid = new DataGridView();
            billingDatePicker = new DateTimePicker();
            mechanicsFeeInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            billingTitleHead = new Label();
            panel1.SuspendLayout();
            billingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billingDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockDataGrid).BeginInit();
            SuspendLayout();
            // 
            // removePartButton
            // 
            removePartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            removePartButton.BackColor = Color.Salmon;
            removePartButton.Cursor = Cursors.Hand;
            removePartButton.Font = new Font("Segoe UI", 12F);
            removePartButton.Location = new Point(505, 526);
            removePartButton.Name = "removePartButton";
            removePartButton.Size = new Size(145, 33);
            removePartButton.TabIndex = 3;
            removePartButton.Text = "Remove Part";
            removePartButton.UseVisualStyleBackColor = false;
            removePartButton.Click += removePartButton_Click;
            // 
            // printButton
            // 
            printButton.Anchor = AnchorStyles.Bottom;
            printButton.BackColor = Color.PaleGreen;
            printButton.Cursor = Cursors.Hand;
            printButton.Font = new Font("Segoe UI", 12F);
            printButton.Location = new Point(848, 631);
            printButton.Name = "printButton";
            printButton.Size = new Size(145, 33);
            printButton.TabIndex = 3;
            printButton.Text = "Print Bill";
            printButton.UseVisualStyleBackColor = false;
            printButton.Click += printButton_Click;
            // 
            // addPartButton
            // 
            addPartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addPartButton.BackColor = Color.SkyBlue;
            addPartButton.Cursor = Cursors.Hand;
            addPartButton.Font = new Font("Segoe UI", 12F);
            addPartButton.Location = new Point(505, 478);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(145, 33);
            addPartButton.TabIndex = 3;
            addPartButton.Text = "Add Part";
            addPartButton.UseVisualStyleBackColor = false;
            addPartButton.Click += addPartButton_Click;
            // 
            // dateInputLable
            // 
            dateInputLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateInputLable.AutoSize = true;
            dateInputLable.Font = new Font("Segoe UI", 12F);
            dateInputLable.Location = new Point(463, 239);
            dateInputLable.Name = "dateInputLable";
            dateInputLable.Size = new Size(42, 21);
            dateInputLable.TabIndex = 2;
            dateInputLable.Text = "Date";
            // 
            // carNumberBoxLable
            // 
            carNumberBoxLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            mechanicsFeeInputLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mechanicsFeeInputLable.AutoSize = true;
            mechanicsFeeInputLable.Font = new Font("Segoe UI", 12F);
            mechanicsFeeInputLable.Location = new Point(463, 308);
            mechanicsFeeInputLable.Name = "mechanicsFeeInputLable";
            mechanicsFeeInputLable.Size = new Size(152, 21);
            mechanicsFeeInputLable.TabIndex = 2;
            mechanicsFeeInputLable.Text = "Mechanics Fee (LKR)";
            // 
            // quantityInputLable
            // 
            quantityInputLable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            quantityInputLable.AutoSize = true;
            quantityInputLable.Font = new Font("Segoe UI", 12F);
            quantityInputLable.Location = new Point(463, 414);
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
            panel1.Controls.Add(employeeName);
            panel1.Controls.Add(billingTable);
            panel1.Controls.Add(billingTitleHead);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 729);
            panel1.TabIndex = 1;
            // 
            // employeeName
            // 
            employeeName.AutoSize = true;
            employeeName.BackColor = Color.Transparent;
            employeeName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeName.ForeColor = Color.White;
            employeeName.Location = new Point(1234, 13);
            employeeName.Name = "employeeName";
            employeeName.Size = new Size(104, 17);
            employeeName.TabIndex = 4;
            employeeName.Text = "Employee Name";
            // 
            // billingTable
            // 
            billingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            billingTable.BackColor = Color.DarkGray;
            billingTable.Controls.Add(numberOfParts);
            billingTable.Controls.Add(numberOfPartsLabel);
            billingTable.Controls.Add(carDateShowingLabel);
            billingTable.Controls.Add(carOwnerNameShowLabel);
            billingTable.Controls.Add(dateLabel);
            billingTable.Controls.Add(carOwnerLabel);
            billingTable.Controls.Add(totalPriceNumber);
            billingTable.Controls.Add(totalPriceLabel);
            billingTable.Controls.Add(billingDataGrid);
            billingTable.Controls.Add(stockLabel);
            billingTable.Controls.Add(carNumberBox);
            billingTable.Controls.Add(stockDataGrid);
            billingTable.Controls.Add(billingDatePicker);
            billingTable.Controls.Add(removePartButton);
            billingTable.Controls.Add(printButton);
            billingTable.Controls.Add(addPartButton);
            billingTable.Controls.Add(dateInputLable);
            billingTable.Controls.Add(carNumberBoxLable);
            billingTable.Controls.Add(mechanicsFeeInputLable);
            billingTable.Controls.Add(quantityInputLable);
            billingTable.Controls.Add(mechanicsFeeInput);
            billingTable.Controls.Add(quantityInput);
            billingTable.Controls.Add(billingInformationLableHead);
            billingTable.Location = new Point(185, 40);
            billingTable.Margin = new Padding(8);
            billingTable.Name = "billingTable";
            billingTable.Size = new Size(1154, 677);
            billingTable.TabIndex = 3;
            // 
            // numberOfParts
            // 
            numberOfParts.AutoSize = true;
            numberOfParts.BackColor = Color.Transparent;
            numberOfParts.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfParts.Location = new Point(150, 579);
            numberOfParts.Name = "numberOfParts";
            numberOfParts.Size = new Size(17, 20);
            numberOfParts.TabIndex = 17;
            numberOfParts.Text = "0";
            // 
            // numberOfPartsLabel
            // 
            numberOfPartsLabel.AutoSize = true;
            numberOfPartsLabel.BackColor = Color.Transparent;
            numberOfPartsLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfPartsLabel.Location = new Point(18, 579);
            numberOfPartsLabel.Name = "numberOfPartsLabel";
            numberOfPartsLabel.Size = new Size(126, 20);
            numberOfPartsLabel.TabIndex = 16;
            numberOfPartsLabel.Text = "Number of Parts:";
            // 
            // carDateShowingLabel
            // 
            carDateShowingLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            carDateShowingLabel.AutoSize = true;
            carDateShowingLabel.BackColor = Color.Transparent;
            carDateShowingLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carDateShowingLabel.Location = new Point(538, 161);
            carDateShowingLabel.Name = "carDateShowingLabel";
            carDateShowingLabel.Size = new Size(13, 17);
            carDateShowingLabel.TabIndex = 15;
            carDateShowingLabel.Text = "-";
            // 
            // carOwnerNameShowLabel
            // 
            carOwnerNameShowLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            carOwnerNameShowLabel.AutoSize = true;
            carOwnerNameShowLabel.BackColor = Color.Transparent;
            carOwnerNameShowLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carOwnerNameShowLabel.Location = new Point(538, 134);
            carOwnerNameShowLabel.Name = "carOwnerNameShowLabel";
            carOwnerNameShowLabel.Size = new Size(13, 17);
            carOwnerNameShowLabel.TabIndex = 14;
            carOwnerNameShowLabel.Text = "-";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(498, 161);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(42, 17);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "Date :";
            // 
            // carOwnerLabel
            // 
            carOwnerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            totalPriceNumber.Anchor = AnchorStyles.Bottom;
            totalPriceNumber.AutoSize = true;
            totalPriceNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceNumber.Location = new Point(1029, 593);
            totalPriceNumber.Name = "totalPriceNumber";
            totalPriceNumber.Size = new Size(23, 25);
            totalPriceNumber.TabIndex = 10;
            totalPriceNumber.Text = "0";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.Anchor = AnchorStyles.Bottom;
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalPriceLabel.Location = new Point(729, 593);
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
            billingDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            billingDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billingDataGrid.BackgroundColor = Color.White;
            billingDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            billingDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            billingDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Black;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            billingDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            billingDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billingDataGrid.Columns.AddRange(new DataGridViewColumn[] { numberTableHead, billingPartId, partsTableHead, quantityTableHead, priceTableHead, totalTableHead });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Black;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            billingDataGrid.DefaultCellStyle = dataGridViewCellStyle10;
            billingDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            billingDataGrid.GridColor = Color.Black;
            billingDataGrid.ImeMode = ImeMode.Off;
            billingDataGrid.Location = new Point(697, 70);
            billingDataGrid.MultiSelect = false;
            billingDataGrid.Name = "billingDataGrid";
            billingDataGrid.ReadOnly = true;
            billingDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            billingDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            billingDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.SkyBlue;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.NullValue = "No data in this Cell";
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            billingDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            billingDataGrid.RowTemplate.Height = 30;
            billingDataGrid.ScrollBars = ScrollBars.Horizontal;
            billingDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billingDataGrid.ShowCellErrors = false;
            billingDataGrid.ShowCellToolTips = false;
            billingDataGrid.ShowEditingIcon = false;
            billingDataGrid.ShowRowErrors = false;
            billingDataGrid.Size = new Size(439, 506);
            billingDataGrid.TabIndex = 7;
            billingDataGrid.CellClick += billingDataGrid_CellClick;
            // 
            // numberTableHead
            // 
            numberTableHead.HeaderText = "Number";
            numberTableHead.Name = "numberTableHead";
            numberTableHead.ReadOnly = true;
            // 
            // billingPartId
            // 
            billingPartId.HeaderText = "PartId";
            billingPartId.Name = "billingPartId";
            billingPartId.ReadOnly = true;
            // 
            // partsTableHead
            // 
            partsTableHead.HeaderText = "Parts";
            partsTableHead.Name = "partsTableHead";
            partsTableHead.ReadOnly = true;
            // 
            // quantityTableHead
            // 
            quantityTableHead.HeaderText = "Quantity";
            quantityTableHead.Name = "quantityTableHead";
            quantityTableHead.ReadOnly = true;
            // 
            // priceTableHead
            // 
            priceTableHead.HeaderText = "Price";
            priceTableHead.Name = "priceTableHead";
            priceTableHead.ReadOnly = true;
            // 
            // totalTableHead
            // 
            totalTableHead.HeaderText = "Total";
            totalTableHead.Name = "totalTableHead";
            totalTableHead.ReadOnly = true;
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
            carNumberBox.AllowDrop = true;
            carNumberBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            carNumberBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carNumberBox.FormattingEnabled = true;
            carNumberBox.Location = new Point(463, 92);
            carNumberBox.MaxDropDownItems = 10;
            carNumberBox.Name = "carNumberBox";
            carNumberBox.Size = new Size(228, 29);
            carNumberBox.TabIndex = 2;
            carNumberBox.SelectedIndexChanged += carNumberBox_SelectedIndexChanged;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Black;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            stockDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            stockDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Black;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            stockDataGrid.DefaultCellStyle = dataGridViewCellStyle14;
            stockDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            stockDataGrid.GridColor = Color.Black;
            stockDataGrid.ImeMode = ImeMode.Off;
            stockDataGrid.Location = new Point(18, 70);
            stockDataGrid.MultiSelect = false;
            stockDataGrid.Name = "stockDataGrid";
            stockDataGrid.ReadOnly = true;
            stockDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            stockDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            stockDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.SkyBlue;
            dataGridViewCellStyle16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.NullValue = "No data in this Cell";
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            stockDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle16;
            stockDataGrid.RowTemplate.Height = 30;
            stockDataGrid.ScrollBars = ScrollBars.Horizontal;
            stockDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockDataGrid.ShowCellErrors = false;
            stockDataGrid.ShowCellToolTips = false;
            stockDataGrid.ShowEditingIcon = false;
            stockDataGrid.ShowRowErrors = false;
            stockDataGrid.Size = new Size(439, 506);
            stockDataGrid.TabIndex = 5;
            stockDataGrid.CellClick += stockDataGrid_CellClick;
            // 
            // billingDatePicker
            // 
            billingDatePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            billingDatePicker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingDatePicker.Location = new Point(463, 263);
            billingDatePicker.Name = "billingDatePicker";
            billingDatePicker.Size = new Size(228, 25);
            billingDatePicker.TabIndex = 4;
            // 
            // mechanicsFeeInput
            // 
            mechanicsFeeInput.AllowPromptAsInput = false;
            mechanicsFeeInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mechanicsFeeInput.Font = new Font("Segoe UI", 10F);
            mechanicsFeeInput.HidePromptOnLeave = true;
            mechanicsFeeInput.Location = new Point(463, 332);
            mechanicsFeeInput.Mask = "0000000000";
            mechanicsFeeInput.Name = "mechanicsFeeInput";
            mechanicsFeeInput.Size = new Size(228, 25);
            mechanicsFeeInput.TabIndex = 1;
            mechanicsFeeInput.Text = "0";
            mechanicsFeeInput.ValidatingType = typeof(int);
            mechanicsFeeInput.TextChanged += mechanicsFeeInput_TextChanged;
            // 
            // quantityInput
            // 
            quantityInput.AllowPromptAsInput = false;
            quantityInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            quantityInput.Font = new Font("Segoe UI", 10F);
            quantityInput.HidePromptOnLeave = true;
            quantityInput.Location = new Point(463, 438);
            quantityInput.Mask = "00000";
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(228, 25);
            quantityInput.TabIndex = 1;
            quantityInput.Text = "1";
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
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Billing";
            Text = "Garage Managment System(GSM)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            billingTable.ResumeLayout(false);
            billingTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billingDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button removePartButton;
        private Button printButton;
        private Button addPartButton;
        private Label dateInputLable;
        private Label carNumberBoxLable;
        private Label mechanicsFeeInputLable;
        private Label quantityInputLable;
        private Label billingInformationLableHead;
        private Panel panel1;
        private Panel billingTable;
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
        private Label carOwnerLabel;
        private Label carDateShowingLabel;
        private Label carOwnerNameShowLabel;
        private Label dateLabel;
        private DataGridViewTextBoxColumn numberTableHead;
        private DataGridViewTextBoxColumn billingPartId;
        private DataGridViewTextBoxColumn partsTableHead;
        private DataGridViewTextBoxColumn quantityTableHead;
        private DataGridViewTextBoxColumn priceTableHead;
        private DataGridViewTextBoxColumn totalTableHead;
        private Label employeeName;
        private Label numberOfParts;
        private Label numberOfPartsLabel;
    }
}