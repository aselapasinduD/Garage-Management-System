namespace GarageTuto
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
            carServicingTableHead = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(carServicingTable);
            panel1.Controls.Add(carServicingTableHead);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1438, 743);
            panel1.TabIndex = 0;
            // 
            // carServicingTable
            // 
            carServicingTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carServicingTable.AutoSize = true;
            carServicingTable.BackColor = Color.Silver;
            carServicingTable.Location = new Point(185, 78);
            carServicingTable.Name = "carServicingTable";
            carServicingTable.Size = new Size(1241, 653);
            carServicingTable.TabIndex = 3;
            // 
            // carServicingTableHead
            // 
            carServicingTableHead.AutoSize = true;
            carServicingTableHead.BackColor = Color.Transparent;
            carServicingTableHead.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carServicingTableHead.ForeColor = Color.White;
            carServicingTableHead.Location = new Point(185, 56);
            carServicingTableHead.Name = "carServicingTableHead";
            carServicingTableHead.Size = new Size(206, 19);
            carServicingTableHead.TabIndex = 2;
            carServicingTableHead.Text = "Record Cars for Servicing";
            carServicingTableHead.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1305, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 743);
            panel2.TabIndex = 0;
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
            ClientSize = new Size(1438, 743);
            Controls.Add(panel1);
            MinimumSize = new Size(1366, 768);
            Name = "Cars";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label carServicingTableHead;
        private Panel carServicingTable;
        private ContextMenuStrip contextMenuStrip1;
    }
}
