namespace ProgramForArrest
{
    partial class AddUserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddUser = new System.Windows.Forms.Button();
            this.btUserImage = new System.Windows.Forms.Button();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.tbUserAddress = new System.Windows.Forms.TextBox();
            this.tbUserBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUserPhone = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.tbUserTitle = new System.Windows.Forms.TextBox();
            this.tbUserPosition = new System.Windows.Forms.TextBox();
            this.tbUserFristname = new System.Windows.Forms.TextBox();
            this.tbUserLastname = new System.Windows.Forms.TextBox();
            this.tbUserCard = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog_User = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAddUser);
            this.panel1.Controls.Add(this.btUserImage);
            this.panel1.Controls.Add(this.pictureBox_User);
            this.panel1.Controls.Add(this.tbUserAddress);
            this.panel1.Controls.Add(this.tbUserBirthday);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbUserPhone);
            this.panel1.Controls.Add(this.tbUserEmail);
            this.panel1.Controls.Add(this.tbUserTitle);
            this.panel1.Controls.Add(this.tbUserPosition);
            this.panel1.Controls.Add(this.tbUserFristname);
            this.panel1.Controls.Add(this.tbUserLastname);
            this.panel1.Controls.Add(this.tbUserCard);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(25, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 518);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Anantason", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(524, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 36);
            this.button1.TabIndex = 104;
            this.button1.Text = "รับข้อมูลผ่านเครื่องอ่านบัตร";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(260, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 48);
            this.label1.TabIndex = 99;
            this.label1.Text = "ข้อมูลผู้ใช้ระบบ";
            // 
            // btAddUser
            // 
            this.btAddUser.Font = new System.Drawing.Font("Anantason", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btAddUser.Location = new System.Drawing.Point(182, 453);
            this.btAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(313, 36);
            this.btAddUser.TabIndex = 102;
            this.btAddUser.Text = "เพิ่มข้อมูล";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // btUserImage
            // 
            this.btUserImage.Font = new System.Drawing.Font("Anantason", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btUserImage.Location = new System.Drawing.Point(546, 196);
            this.btUserImage.Margin = new System.Windows.Forms.Padding(2);
            this.btUserImage.Name = "btUserImage";
            this.btUserImage.Size = new System.Drawing.Size(129, 36);
            this.btUserImage.TabIndex = 100;
            this.btUserImage.Text = "เลือกรูปภาพ";
            this.btUserImage.UseVisualStyleBackColor = true;
            this.btUserImage.Click += new System.EventHandler(this.btUserImage_Click);
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_User.Location = new System.Drawing.Point(546, 25);
            this.pictureBox_User.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(129, 157);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 101;
            this.pictureBox_User.TabStop = false;
            // 
            // tbUserAddress
            // 
            this.tbUserAddress.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserAddress.Location = new System.Drawing.Point(181, 235);
            this.tbUserAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserAddress.Multiline = true;
            this.tbUserAddress.Name = "tbUserAddress";
            this.tbUserAddress.Size = new System.Drawing.Size(314, 50);
            this.tbUserAddress.TabIndex = 87;
            // 
            // tbUserBirthday
            // 
            this.tbUserBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserBirthday.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserBirthday.Location = new System.Drawing.Point(344, 165);
            this.tbUserBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserBirthday.Name = "tbUserBirthday";
            this.tbUserBirthday.Size = new System.Drawing.Size(152, 31);
            this.tbUserBirthday.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(182, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 94;
            this.label7.Text = "ตำแหน่ง";
            // 
            // tbUserPhone
            // 
            this.tbUserPhone.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserPhone.Location = new System.Drawing.Point(361, 391);
            this.tbUserPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserPhone.Name = "tbUserPhone";
            this.tbUserPhone.Size = new System.Drawing.Size(135, 31);
            this.tbUserPhone.TabIndex = 86;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserEmail.Location = new System.Drawing.Point(182, 391);
            this.tbUserEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(168, 31);
            this.tbUserEmail.TabIndex = 85;
            // 
            // tbUserTitle
            // 
            this.tbUserTitle.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserTitle.Location = new System.Drawing.Point(181, 96);
            this.tbUserTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserTitle.Name = "tbUserTitle";
            this.tbUserTitle.Size = new System.Drawing.Size(86, 31);
            this.tbUserTitle.TabIndex = 79;
            // 
            // tbUserPosition
            // 
            this.tbUserPosition.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserPosition.Location = new System.Drawing.Point(184, 322);
            this.tbUserPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserPosition.Name = "tbUserPosition";
            this.tbUserPosition.Size = new System.Drawing.Size(312, 31);
            this.tbUserPosition.TabIndex = 84;
            // 
            // tbUserFristname
            // 
            this.tbUserFristname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserFristname.Location = new System.Drawing.Point(274, 96);
            this.tbUserFristname.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserFristname.Name = "tbUserFristname";
            this.tbUserFristname.Size = new System.Drawing.Size(108, 31);
            this.tbUserFristname.TabIndex = 80;
            // 
            // tbUserLastname
            // 
            this.tbUserLastname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserLastname.Location = new System.Drawing.Point(388, 96);
            this.tbUserLastname.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserLastname.Name = "tbUserLastname";
            this.tbUserLastname.Size = new System.Drawing.Size(108, 31);
            this.tbUserLastname.TabIndex = 81;
            // 
            // tbUserCard
            // 
            this.tbUserCard.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserCard.Location = new System.Drawing.Point(181, 165);
            this.tbUserCard.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserCard.Name = "tbUserCard";
            this.tbUserCard.Size = new System.Drawing.Size(156, 31);
            this.tbUserCard.TabIndex = 82;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.Location = new System.Drawing.Point(180, 74);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 24);
            this.label18.TabIndex = 88;
            this.label18.Text = "คำนำหน้า";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(340, 140);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 24);
            this.label14.TabIndex = 92;
            this.label14.Text = "วันเกิด";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(271, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 24);
            this.label17.TabIndex = 89;
            this.label17.Text = "ชื่อ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(180, 140);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 24);
            this.label15.TabIndex = 91;
            this.label15.Text = "เลขประชาชนประจำตัว";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(381, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 24);
            this.label16.TabIndex = 90;
            this.label16.Text = "นามสกุล";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(180, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 95;
            this.label8.Text = "อีเมล";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(176, 208);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 24);
            this.label12.TabIndex = 97;
            this.label12.Text = "ที่อยู่";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(356, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "เบอร์โทรศัพท์";
            // 
            // openFileDialog_User
            // 
            this.openFileDialog_User.FileName = "openFileDialog1";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(774, 593);
            this.Controls.Add(this.panel1);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsecrForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserAddress;
        private System.Windows.Forms.DateTimePicker tbUserBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUserPhone;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.TextBox tbUserTitle;
        private System.Windows.Forms.TextBox tbUserPosition;
        private System.Windows.Forms.TextBox tbUserFristname;
        private System.Windows.Forms.TextBox tbUserLastname;
        private System.Windows.Forms.TextBox tbUserCard;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btUserImage;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Button btAddUser;
        private System.Windows.Forms.OpenFileDialog openFileDialog_User;
        private System.Windows.Forms.Button button1;
    }
}