﻿namespace GarageTuto
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            partTableTitleHead = new Label();
            stockPanel = new Panel();
            carServicingTable = new Panel();
            stockInformationDataGrid = new DataGridView();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            priceInputLable = new Label();
            quantityInputLable = new Label();
            partNumberInputLable = new Label();
            priceInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            partNameInput = new MaskedTextBox();
            partsInformationLableHead = new Label();
            numberOfParts = new Label();
            numberOfPartsLabel = new Label();
            stockPanel.SuspendLayout();
            carServicingTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockInformationDataGrid).BeginInit();
            SuspendLayout();
            // 
            // partTableTitleHead
            // 
            partTableTitleHead.AutoSize = true;
            partTableTitleHead.BackColor = Color.Transparent;
            partTableTitleHead.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partTableTitleHead.ForeColor = Color.White;
            partTableTitleHead.Location = new Point(185, 6);
            partTableTitleHead.Name = "partTableTitleHead";
            partTableTitleHead.Size = new Size(288, 31);
            partTableTitleHead.TabIndex = 2;
            partTableTitleHead.Text = "Record Cars for Servicing";
            // 
            // stockPanel
            // 
            stockPanel.BackColor = Color.Black;
            stockPanel.Controls.Add(carServicingTable);
            stockPanel.Controls.Add(partTableTitleHead);
            stockPanel.Dock = DockStyle.Fill;
            stockPanel.Location = new Point(0, 0);
            stockPanel.Name = "stockPanel";
            stockPanel.Size = new Size(1366, 768);
            stockPanel.TabIndex = 1;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.BackColor = Color.DarkGray;
            carServicingTable.Controls.Add(numberOfParts);
            carServicingTable.Controls.Add(numberOfPartsLabel);
            carServicingTable.Controls.Add(stockInformationDataGrid);
            carServicingTable.Controls.Add(deleteButton);
            carServicingTable.Controls.Add(editButton);
            carServicingTable.Controls.Add(addButton);
            carServicingTable.Controls.Add(priceInputLable);
            carServicingTable.Controls.Add(quantityInputLable);
            carServicingTable.Controls.Add(partNumberInputLable);
            carServicingTable.Controls.Add(priceInput);
            carServicingTable.Controls.Add(quantityInput);
            carServicingTable.Controls.Add(partNameInput);
            carServicingTable.Controls.Add(partsInformationLableHead);
            carServicingTable.Location = new Point(185, 40);
            carServicingTable.Margin = new Padding(8);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1170, 716);
            carServicingTable.TabIndex = 3;
            // 
            // stockInformationDataGrid
            // 
            stockInformationDataGrid.AllowUserToAddRows = false;
            stockInformationDataGrid.AllowUserToDeleteRows = false;
            stockInformationDataGrid.AllowUserToResizeColumns = false;
            stockInformationDataGrid.AllowUserToResizeRows = false;
            stockInformationDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stockInformationDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            stockInformationDataGrid.BackgroundColor = Color.White;
            stockInformationDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            stockInformationDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            stockInformationDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            stockInformationDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            stockInformationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Black;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            stockInformationDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            stockInformationDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            stockInformationDataGrid.GridColor = Color.Black;
            stockInformationDataGrid.ImeMode = ImeMode.Off;
            stockInformationDataGrid.Location = new Point(18, 168);
            stockInformationDataGrid.MultiSelect = false;
            stockInformationDataGrid.Name = "stockInformationDataGrid";
            stockInformationDataGrid.ReadOnly = true;
            stockInformationDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            stockInformationDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            stockInformationDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.SkyBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.NullValue = "No data in this Cell";
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            stockInformationDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            stockInformationDataGrid.RowTemplate.Height = 30;
            stockInformationDataGrid.ScrollBars = ScrollBars.Horizontal;
            stockInformationDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockInformationDataGrid.ShowCellErrors = false;
            stockInformationDataGrid.ShowCellToolTips = false;
            stockInformationDataGrid.ShowEditingIcon = false;
            stockInformationDataGrid.ShowRowErrors = false;
            stockInformationDataGrid.Size = new Size(1134, 532);
            stockInformationDataGrid.TabIndex = 8;
            stockInformationDataGrid.CellClick += stockInformationDataGrid_CellClick;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Salmon;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Segoe UI", 12F);
            deleteButton.Location = new Point(368, 114);
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
            editButton.Location = new Point(193, 114);
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
            addButton.Location = new Point(18, 114);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 33);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // priceInputLable
            // 
            priceInputLable.AutoSize = true;
            priceInputLable.Font = new Font("Segoe UI", 12F);
            priceInputLable.Location = new Point(472, 48);
            priceInputLable.Name = "priceInputLable";
            priceInputLable.Size = new Size(44, 21);
            priceInputLable.TabIndex = 2;
            priceInputLable.Text = "Price";
            // 
            // quantityInputLable
            // 
            quantityInputLable.AutoSize = true;
            quantityInputLable.Font = new Font("Segoe UI", 12F);
            quantityInputLable.Location = new Point(245, 48);
            quantityInputLable.Name = "quantityInputLable";
            quantityInputLable.Size = new Size(70, 21);
            quantityInputLable.TabIndex = 2;
            quantityInputLable.Text = "Quantity";
            // 
            // partNumberInputLable
            // 
            partNumberInputLable.AutoSize = true;
            partNumberInputLable.Font = new Font("Segoe UI", 12F);
            partNumberInputLable.Location = new Point(18, 48);
            partNumberInputLable.Name = "partNumberInputLable";
            partNumberInputLable.Size = new Size(83, 21);
            partNumberInputLable.TabIndex = 2;
            partNumberInputLable.Text = "Part Name";
            // 
            // priceInput
            // 
            priceInput.AllowPromptAsInput = false;
            priceInput.Font = new Font("Segoe UI", 10F);
            priceInput.HidePromptOnLeave = true;
            priceInput.Location = new Point(472, 72);
            priceInput.Mask = "0000000000";
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(200, 25);
            priceInput.TabIndex = 1;
            priceInput.ValidatingType = typeof(int);
            // 
            // quantityInput
            // 
            quantityInput.AllowPromptAsInput = false;
            quantityInput.Font = new Font("Segoe UI", 10F);
            quantityInput.HidePromptOnLeave = true;
            quantityInput.Location = new Point(245, 72);
            quantityInput.Mask = "0000000000";
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(200, 25);
            quantityInput.TabIndex = 1;
            quantityInput.ValidatingType = typeof(int);
            // 
            // partNameInput
            // 
            partNameInput.Font = new Font("Segoe UI", 10F);
            partNameInput.Location = new Point(18, 72);
            partNameInput.Name = "partNameInput";
            partNameInput.Size = new Size(200, 25);
            partNameInput.TabIndex = 1;
            // 
            // partsInformationLableHead
            // 
            partsInformationLableHead.AutoSize = true;
            partsInformationLableHead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            partsInformationLableHead.ForeColor = Color.White;
            partsInformationLableHead.Location = new Point(3, 12);
            partsInformationLableHead.Name = "partsInformationLableHead";
            partsInformationLableHead.Size = new Size(186, 30);
            partsInformationLableHead.TabIndex = 0;
            partsInformationLableHead.Text = "Parts Information";
            // 
            // numberOfParts
            // 
            numberOfParts.AutoSize = true;
            numberOfParts.BackColor = Color.Transparent;
            numberOfParts.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfParts.Location = new Point(1102, 145);
            numberOfParts.Name = "numberOfParts";
            numberOfParts.Size = new Size(17, 20);
            numberOfParts.TabIndex = 10;
            numberOfParts.Text = "0";
            // 
            // numberOfPartsLabel
            // 
            numberOfPartsLabel.AutoSize = true;
            numberOfPartsLabel.BackColor = Color.Transparent;
            numberOfPartsLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numberOfPartsLabel.Location = new Point(970, 145);
            numberOfPartsLabel.Name = "numberOfPartsLabel";
            numberOfPartsLabel.Size = new Size(126, 20);
            numberOfPartsLabel.TabIndex = 9;
            numberOfPartsLabel.Text = "Number of Parts:";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(stockPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Stock";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Garage Managment System(GSM)";
            stockPanel.ResumeLayout(false);
            stockPanel.PerformLayout();
            carServicingTable.ResumeLayout(false);
            carServicingTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockInformationDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label partTableTitleHead;
        private Panel stockPanel;
        private Panel carServicingTable;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label priceInputLable;
        private Label quantityInputLable;
        private Label partNumberInputLable;
        private MaskedTextBox priceInput;
        private MaskedTextBox quantityInput;
        private MaskedTextBox partNameInput;
        private Label partsInformationLableHead;
        private DataGridView stockInformationDataGrid;
        private Label numberOfParts;
        private Label numberOfPartsLabel;
    }
}