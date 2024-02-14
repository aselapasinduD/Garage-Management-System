namespace GarageTuto
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            signInButton = new Button();
            label3 = new Label();
            passwordInput = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            employeeSignIn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.DialogResult = DialogResult.Continue;
            signInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInButton.Location = new Point(101, 263);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(120, 36);
            signInButton.TabIndex = 19;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 184);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(99, 181);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(189, 27);
            passwordInput.TabIndex = 17;
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
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
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
            label1.TabIndex = 13;
            label1.Text = "Garage Managment System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeeSignIn
            // 
            employeeSignIn.AutoSize = true;
            employeeSignIn.BackColor = Color.Transparent;
            employeeSignIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            employeeSignIn.Location = new Point(99, 310);
            employeeSignIn.Name = "employeeSignIn";
            employeeSignIn.Size = new Size(124, 20);
            employeeSignIn.TabIndex = 20;
            employeeSignIn.Text = "Employee Sign In";
            employeeSignIn.Click += employeeSignIn_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(325, 341);
            Controls.Add(employeeSignIn);
            Controls.Add(signInButton);
            Controls.Add(label3);
            Controls.Add(passwordInput);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Garage Managment System(GSM)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private Label label3;
        private MaskedTextBox passwordInput;
        private PictureBox pictureBox1;
        private Label label1;
        private Label employeeSignIn;
    }
}