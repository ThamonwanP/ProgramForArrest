namespace ProgramForArrest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox_Pass = new System.Windows.Forms.PictureBox();
            this.pictureBox_Finger = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Card = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Card)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason SemiExpanded", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(124, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "เข้าสู่ระบบ";
            // 
            // btLogin
            // 
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Anantason SemiExpanded", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btLogin.Location = new System.Drawing.Point(60, 463);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(250, 49);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "เข้าสู่ระบบ";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbCard
            // 
            this.tbCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(125)))));
            this.tbCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tbCard.Location = new System.Drawing.Point(115, 299);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(194, 20);
            this.tbCard.TabIndex = 3;
            this.tbCard.Text = "1234567890111";
            this.tbCard.Click += new System.EventHandler(this.tbCard_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(125)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tbPassword.Location = new System.Drawing.Point(115, 383);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(261, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "1234567890111";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // pictureBox_Pass
            // 
            this.pictureBox_Pass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Pass.Image")));
            this.pictureBox_Pass.Location = new System.Drawing.Point(60, 368);
            this.pictureBox_Pass.Name = "pictureBox_Pass";
            this.pictureBox_Pass.Size = new System.Drawing.Size(44, 44);
            this.pictureBox_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pass.TabIndex = 8;
            this.pictureBox_Pass.TabStop = false;
            // 
            // pictureBox_Finger
            // 
            this.pictureBox_Finger.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Finger.Image")));
            this.pictureBox_Finger.Location = new System.Drawing.Point(144, 83);
            this.pictureBox_Finger.Name = "pictureBox_Finger";
            this.pictureBox_Finger.Size = new System.Drawing.Size(85, 103);
            this.pictureBox_Finger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Finger.TabIndex = 9;
            this.pictureBox_Finger.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Location = new System.Drawing.Point(60, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.Location = new System.Drawing.Point(60, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox_Card
            // 
            this.pictureBox_Card.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Card.Image")));
            this.pictureBox_Card.Location = new System.Drawing.Point(60, 290);
            this.pictureBox_Card.Name = "pictureBox_Card";
            this.pictureBox_Card.Size = new System.Drawing.Size(44, 44);
            this.pictureBox_Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Card.TabIndex = 12;
            this.pictureBox_Card.TabStop = false;
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.Font = new System.Drawing.Font("Anantason SemiExpanded", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btClose.Location = new System.Drawing.Point(327, 8);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(33, 42);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(371, 650);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox_Card);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Finger);
            this.Controls.Add(this.pictureBox_Pass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbCard);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox_Finger;
        private System.Windows.Forms.PictureBox pictureBox_Pass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Card;
        private System.Windows.Forms.Label btClose;
    }
}

