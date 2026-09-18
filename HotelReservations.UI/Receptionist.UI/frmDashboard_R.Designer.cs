namespace HotelReservations.UI.Receptionist.UI
{
    partial class frmDashboard_R
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 218, 224);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(141, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(666, 50);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 64, 80);
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 2;
            label1.Text = "Receptionist Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 464);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(48, 91, 171);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Franklin Gothic Heavy", 7.8F);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(32, 155);
            button3.Name = "button3";
            button3.Size = new Size(97, 26);
            button3.TabIndex = 4;
            button3.Text = "MY ACCOUNT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(48, 91, 171);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Heavy", 7.8F);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(32, 124);
            button2.Name = "button2";
            button2.Size = new Size(97, 26);
            button2.TabIndex = 3;
            button2.Text = "BOOKINGS";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 91, 171);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Franklin Gothic Heavy", 7.8F);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(32, 93);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 2;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 7.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(21, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 13);
            label2.TabIndex = 3;
            label2.Text = "Navigations";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 51);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmDashboard_R
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDashboard_R";
            Text = "Receptionist Dashboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}