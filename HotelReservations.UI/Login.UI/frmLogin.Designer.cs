namespace HotelReservations.UI.Login.UI
{
    partial class frmLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(215, 218, 224);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(243, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 386);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 128);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(44, 158);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtUsername.Location = new Point(46, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 32);
            txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(44, 230);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtPassword.Location = new Point(46, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(226, 32);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Constantia", 12F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(98, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 69, 115);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}