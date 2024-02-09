namespace GarageTuto
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            menuPanel = new Panel();
            logoutMenuLable = new Label();
            analyticsMenuLable = new Label();
            billingMenuLable = new Label();
            employeesMenuLable = new Label();
            stockMenuLable = new Label();
            carMenuLable = new Label();
            carPictureLogo = new PictureBox();
            mainPanel = new Panel();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).BeginInit();
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
            menuPanel.TabIndex = 1;
            // 
            // logoutMenuLable
            // 
            logoutMenuLable.AutoSize = true;
            logoutMenuLable.BackColor = Color.Transparent;
            logoutMenuLable.Cursor = Cursors.Hand;
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
            analyticsMenuLable.Cursor = Cursors.Hand;
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
            billingMenuLable.Cursor = Cursors.Hand;
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
            employeesMenuLable.Cursor = Cursors.Hand;
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
            stockMenuLable.Cursor = Cursors.Hand;
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
            carMenuLable.Cursor = Cursors.Hand;
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
            carPictureLogo.Location = new Point(3, 3);
            carPictureLogo.Name = "carPictureLogo";
            carPictureLogo.Size = new Size(163, 99);
            carPictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            carPictureLogo.TabIndex = 1;
            carPictureLogo.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Black;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1350, 729);
            mainPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(menuPanel);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1366, 768);
            Name = "MainWindow";
            Text = "Garage Managment System(GSM)";
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carPictureLogo).EndInit();
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
        private Panel mainPanel;
    }
}