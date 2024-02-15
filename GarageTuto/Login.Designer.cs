namespace GarageTuto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            employeeNameInput = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            passwordInput = new MaskedTextBox();
            signInButton = new Button();
            adminSignIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(250, 25);
            label1.TabIndex = 5;
            label1.Text = "Garage Managment System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.gms_icons;
            pictureBox1.Location = new Point(124, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // employeeNameInput
            // 
            employeeNameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeNameInput.Location = new Point(127, 161);
            employeeNameInput.Name = "employeeNameInput";
            employeeNameInput.Size = new Size(189, 27);
            employeeNameInput.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 164);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 9;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 214);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(127, 211);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(189, 27);
            passwordInput.TabIndex = 10;
            // 
            // signInButton
            // 
            signInButton.DialogResult = DialogResult.Continue;
            signInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInButton.Location = new Point(101, 263);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(120, 36);
            signInButton.TabIndex = 12;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // adminSignIn
            // 
            adminSignIn.AutoSize = true;
            adminSignIn.BackColor = Color.Transparent;
            adminSignIn.Cursor = Cursors.Hand;
            adminSignIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            adminSignIn.Location = new Point(110, 310);
            adminSignIn.Name = "adminSignIn";
            adminSignIn.Size = new Size(102, 20);
            adminSignIn.TabIndex = 13;
            adminSignIn.Text = "Admin Sign In";
            adminSignIn.Click += adminSignIn_Click;
            // 
            // Login
            // 
            AcceptButton = signInButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(325, 341);
            Controls.Add(adminSignIn);
            Controls.Add(signInButton);
            Controls.Add(label3);
            Controls.Add(passwordInput);
            Controls.Add(label2);
            Controls.Add(employeeNameInput);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Garage Managment System(GSM)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox employeeNameInput;
        private Label label2;
        private Label label3;
        private MaskedTextBox passwordInput;
        private Button signInButton;
        private Label adminSignIn;
    }
}