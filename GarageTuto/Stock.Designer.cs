namespace GarageTuto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            contextMenuStrip1 = new ContextMenuStrip(components);
            logoutMenuLable = new Label();
            analyticsMenuLable = new Label();
            billingMenuLable = new Label();
            employeesMenuLable = new Label();
            stockMenuLable = new Label();
            carMenuLable = new Label();
            partTableTitleHead = new Label();
            menuPanel = new Panel();
            carPictureLogo = new PictureBox();
            carInformationTablePanel = new Panel();
            panel1 = new Panel();
            carServicingTable = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            priceInputLable = new Label();
            quantityInputLable = new Label();
            partNumberInputLable = new Label();
            priceInput = new MaskedTextBox();
            quantityInput = new MaskedTextBox();
            partNumberInput = new MaskedTextBox();
            partsInformationLableHead = new Label();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).BeginInit();
            panel1.SuspendLayout();
            carServicingTable.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            stockMenuLable.BackColor = Color.Black;
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
            carMenuLable.BackColor = Color.Transparent;
            carMenuLable.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carMenuLable.ForeColor = Color.White;
            carMenuLable.Location = new Point(15, 140);
            carMenuLable.Name = "carMenuLable";
            carMenuLable.Size = new Size(154, 30);
            carMenuLable.TabIndex = 0;
            carMenuLable.Text = "Cars";
            carMenuLable.Click += carMenuLable_Click;
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
            // carInformationTablePanel
            // 
            carInformationTablePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carInformationTablePanel.BackColor = Color.White;
            carInformationTablePanel.Location = new Point(18, 164);
            carInformationTablePanel.Margin = new Padding(8);
            carInformationTablePanel.Name = "carInformationTablePanel";
            carInformationTablePanel.Size = new Size(1118, 497);
            carInformationTablePanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(carServicingTable);
            panel1.Controls.Add(partTableTitleHead);
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
            carServicingTable.Controls.Add(carInformationTablePanel);
            carServicingTable.Controls.Add(deleteButton);
            carServicingTable.Controls.Add(editButton);
            carServicingTable.Controls.Add(addButton);
            carServicingTable.Controls.Add(priceInputLable);
            carServicingTable.Controls.Add(quantityInputLable);
            carServicingTable.Controls.Add(partNumberInputLable);
            carServicingTable.Controls.Add(priceInput);
            carServicingTable.Controls.Add(quantityInput);
            carServicingTable.Controls.Add(partNumberInput);
            carServicingTable.Controls.Add(partsInformationLableHead);
            carServicingTable.Location = new Point(185, 40);
            carServicingTable.Margin = new Padding(8);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1154, 677);
            carServicingTable.TabIndex = 3;
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
            partNumberInputLable.Size = new Size(99, 21);
            partNumberInputLable.TabIndex = 2;
            partNumberInputLable.Text = "Part Number";
            // 
            // priceInput
            // 
            priceInput.Font = new Font("Segoe UI", 10F);
            priceInput.Location = new Point(472, 72);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(200, 25);
            priceInput.TabIndex = 1;
            priceInput.MaskInputRejected += priceInput_MaskInputRejected;
            // 
            // quantityInput
            // 
            quantityInput.Font = new Font("Segoe UI", 10F);
            quantityInput.Location = new Point(245, 72);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(200, 25);
            quantityInput.TabIndex = 1;
            quantityInput.MaskInputRejected += quantityInput_MaskInputRejected;
            // 
            // partNumberInput
            // 
            partNumberInput.Font = new Font("Segoe UI", 10F);
            partNumberInput.Location = new Point(18, 72);
            partNumberInput.Name = "partNumberInput";
            partNumberInput.Size = new Size(200, 25);
            partNumberInput.TabIndex = 1;
            partNumberInput.MaskInputRejected += partNumberInput_MaskInputRejected;
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
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "Stock";
            Text = "Garage Managment System(GSM)";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            carServicingTable.ResumeLayout(false);
            carServicingTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label logoutMenuLable;
        private Label analyticsMenuLable;
        private Label billingMenuLable;
        private Label employeesMenuLable;
        private Label stockMenuLable;
        private Label carMenuLable;
        private Label partTableTitleHead;
        private Panel menuPanel;
        private PictureBox carPictureLogo;
        private Panel carInformationTablePanel;
        private Panel panel1;
        private Panel carServicingTable;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label priceInputLable;
        private Label quantityInputLable;
        private Label partNumberInputLable;
        private MaskedTextBox priceInput;
        private MaskedTextBox quantityInput;
        private MaskedTextBox partNumberInput;
        private Label partsInformationLableHead;
    }
}