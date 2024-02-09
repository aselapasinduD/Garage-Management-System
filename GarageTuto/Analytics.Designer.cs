namespace GarageTuto
{
    partial class Analytics
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
            analyticsPanel = new Panel();
            analyticsTable = new Panel();
            panel6 = new Panel();
            financeNumber = new Label();
            financeLabel = new Label();
            panel7 = new Panel();
            panel4 = new Panel();
            employeesNumber = new Label();
            employeesLabel = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            stockNumber = new Label();
            stockLabel = new Label();
            panel3 = new Panel();
            analyticsCard = new Panel();
            carNumber = new Label();
            label2 = new Label();
            panel2 = new Panel();
            analyticsLableHead = new Label();
            DashBoardTitleHead = new Label();
            analyticsPanel.SuspendLayout();
            analyticsTable.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            analyticsCard.SuspendLayout();
            SuspendLayout();
            // 
            // analyticsPanel
            // 
            analyticsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            analyticsPanel.BackColor = Color.Black;
            analyticsPanel.Controls.Add(analyticsTable);
            analyticsPanel.Controls.Add(DashBoardTitleHead);
            analyticsPanel.Location = new Point(0, 0);
            analyticsPanel.Name = "analyticsPanel";
            analyticsPanel.Size = new Size(1366, 768);
            analyticsPanel.TabIndex = 2;
            // 
            // analyticsTable
            // 
            analyticsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            analyticsTable.BackColor = Color.DarkGray;
            analyticsTable.Controls.Add(panel6);
            analyticsTable.Controls.Add(panel4);
            analyticsTable.Controls.Add(panel1);
            analyticsTable.Controls.Add(analyticsCard);
            analyticsTable.Controls.Add(analyticsLableHead);
            analyticsTable.Location = new Point(185, 40);
            analyticsTable.Margin = new Padding(8);
            analyticsTable.Name = "analyticsTable";
            analyticsTable.Size = new Size(1170, 716);
            analyticsTable.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(financeNumber);
            panel6.Controls.Add(financeLabel);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(894, 63);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 1;
            // 
            // financeNumber
            // 
            financeNumber.AutoSize = true;
            financeNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            financeNumber.Location = new Point(56, 55);
            financeNumber.Name = "financeNumber";
            financeNumber.Size = new Size(23, 25);
            financeNumber.TabIndex = 1;
            financeNumber.Text = "0";
            // 
            // financeLabel
            // 
            financeLabel.AutoSize = true;
            financeLabel.BackColor = Color.Transparent;
            financeLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            financeLabel.Location = new Point(56, 10);
            financeLabel.Name = "financeLabel";
            financeLabel.Size = new Size(97, 32);
            financeLabel.TabIndex = 1;
            financeLabel.Text = "Finance";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(15, 100);
            panel7.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(employeesNumber);
            panel4.Controls.Add(employeesLabel);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(618, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 1;
            // 
            // employeesNumber
            // 
            employeesNumber.AutoSize = true;
            employeesNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesNumber.Location = new Point(97, 55);
            employeesNumber.Name = "employeesNumber";
            employeesNumber.Size = new Size(23, 25);
            employeesNumber.TabIndex = 1;
            employeesNumber.Text = "0";
            // 
            // employeesLabel
            // 
            employeesLabel.AutoSize = true;
            employeesLabel.BackColor = Color.Transparent;
            employeesLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeesLabel.Location = new Point(44, 10);
            employeesLabel.Name = "employeesLabel";
            employeesLabel.Size = new Size(129, 32);
            employeesLabel.TabIndex = 1;
            employeesLabel.Text = "Employees";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(15, 100);
            panel5.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(stockNumber);
            panel1.Controls.Add(stockLabel);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(342, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // stockNumber
            // 
            stockNumber.AutoSize = true;
            stockNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockNumber.Location = new Point(95, 55);
            stockNumber.Name = "stockNumber";
            stockNumber.Size = new Size(23, 25);
            stockNumber.TabIndex = 1;
            stockNumber.Text = "0";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.BackColor = Color.Transparent;
            stockLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stockLabel.Location = new Point(70, 10);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new Size(73, 32);
            stockLabel.TabIndex = 1;
            stockLabel.Text = "Stock";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(15, 100);
            panel3.TabIndex = 0;
            // 
            // analyticsCard
            // 
            analyticsCard.BackColor = Color.White;
            analyticsCard.Controls.Add(carNumber);
            analyticsCard.Controls.Add(label2);
            analyticsCard.Controls.Add(panel2);
            analyticsCard.Location = new Point(66, 63);
            analyticsCard.Name = "analyticsCard";
            analyticsCard.Size = new Size(200, 100);
            analyticsCard.TabIndex = 1;
            // 
            // carNumber
            // 
            carNumber.AutoSize = true;
            carNumber.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carNumber.Location = new Point(89, 55);
            carNumber.Name = "carNumber";
            carNumber.Size = new Size(23, 25);
            carNumber.TabIndex = 1;
            carNumber.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 10);
            label2.Name = "label2";
            label2.Size = new Size(61, 32);
            label2.TabIndex = 1;
            label2.Text = "Cars";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 100);
            panel2.TabIndex = 0;
            // 
            // analyticsLableHead
            // 
            analyticsLableHead.AutoSize = true;
            analyticsLableHead.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            analyticsLableHead.ForeColor = Color.White;
            analyticsLableHead.Location = new Point(3, 12);
            analyticsLableHead.Name = "analyticsLableHead";
            analyticsLableHead.Size = new Size(102, 30);
            analyticsLableHead.TabIndex = 0;
            analyticsLableHead.Text = "Analytics";
            // 
            // DashBoardTitleHead
            // 
            DashBoardTitleHead.AutoSize = true;
            DashBoardTitleHead.BackColor = Color.Transparent;
            DashBoardTitleHead.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardTitleHead.ForeColor = Color.White;
            DashBoardTitleHead.Location = new Point(185, 6);
            DashBoardTitleHead.Name = "DashBoardTitleHead";
            DashBoardTitleHead.Size = new Size(133, 31);
            DashBoardTitleHead.TabIndex = 2;
            DashBoardTitleHead.Text = "DashBoard";
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(analyticsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Analytics";
            Text = "Analytics";
            analyticsPanel.ResumeLayout(false);
            analyticsPanel.PerformLayout();
            analyticsTable.ResumeLayout(false);
            analyticsTable.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            analyticsCard.ResumeLayout(false);
            analyticsCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel analyticsPanel;
        private Panel analyticsTable;
        private Label analyticsLableHead;
        private Label DashBoardTitleHead;
        private Panel analyticsCard;
        private Panel panel2;
        private Panel panel6;
        private Label financeNumber;
        private Label financeLabel;
        private Panel panel7;
        private Panel panel4;
        private Label employeesNumber;
        private Label employeesLabel;
        private Panel panel5;
        private Panel panel1;
        private Label stockNumber;
        private Label stockLabel;
        private Panel panel3;
        private Label carNumber;
        private Label label2;
    }
}