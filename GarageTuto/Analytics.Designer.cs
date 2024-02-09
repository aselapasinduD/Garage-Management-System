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
            analyticsLableHead = new Label();
            DashBoardTitleHead = new Label();
            analyticsPanel.SuspendLayout();
            analyticsTable.SuspendLayout();
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
            analyticsTable.Controls.Add(analyticsLableHead);
            analyticsTable.Location = new Point(185, 40);
            analyticsTable.Margin = new Padding(8);
            analyticsTable.Name = "analyticsTable";
            analyticsTable.Size = new Size(1170, 716);
            analyticsTable.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel analyticsPanel;
        private Panel analyticsTable;
        private Label analyticsLableHead;
        private Label DashBoardTitleHead;
    }
}