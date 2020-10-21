namespace ProgramForArrest
{
    partial class AddPersonForm
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
            this.btClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPersonTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pictureBox_Person = new System.Windows.Forms.PictureBox();
            this.tbPersonAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPersonBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPersonGroup = new System.Windows.Forms.TextBox();
            this.tbPersonLastname = new System.Windows.Forms.TextBox();
            this.tbPersonPhone = new System.Windows.Forms.TextBox();
            this.tbPersonFirstname = new System.Windows.Forms.TextBox();
            this.tbPersonCard = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog_Person = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Person)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(899, 27);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(36, 36);
            this.btClose.TabIndex = 101;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(341, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 60);
            this.label1.TabIndex = 102;
            this.label1.Text = "ข้อมูลผู้ต้องหา";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbPersonTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btAddPerson);
            this.panel1.Controls.Add(this.pictureBox_Person);
            this.panel1.Controls.Add(this.tbPersonAddress);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbPersonBirthday);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbPersonGroup);
            this.panel1.Controls.Add(this.tbPersonLastname);
            this.panel1.Controls.Add(this.tbPersonPhone);
            this.panel1.Controls.Add(this.tbPersonFirstname);
            this.panel1.Controls.Add(this.tbPersonCard);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 622);
            this.panel1.TabIndex = 100;
            // 
            // tbPersonTitle
            // 
            this.tbPersonTitle.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonTitle.Location = new System.Drawing.Point(187, 116);
            this.tbPersonTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonTitle.Name = "tbPersonTitle";
            this.tbPersonTitle.Size = new System.Drawing.Size(105, 37);
            this.tbPersonTitle.TabIndex = 104;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(657, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 38);
            this.button1.TabIndex = 103;
            this.button1.Text = "รับข้อมูลผ่านเครื่องอ่านบัตร";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btAddPerson.Location = new System.Drawing.Point(183, 481);
            this.btAddPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(419, 44);
            this.btAddPerson.TabIndex = 102;
            this.btAddPerson.Text = "เพิ่มข้อมูล";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pictureBox_Person
            // 
            this.pictureBox_Person.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Person.Location = new System.Drawing.Point(677, 50);
            this.pictureBox_Person.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Person.Name = "pictureBox_Person";
            this.pictureBox_Person.Size = new System.Drawing.Size(163, 175);
            this.pictureBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Person.TabIndex = 101;
            this.pictureBox_Person.TabStop = false;
            // 
            // tbPersonAddress
            // 
            this.tbPersonAddress.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonAddress.Location = new System.Drawing.Point(183, 281);
            this.tbPersonAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonAddress.Multiline = true;
            this.tbPersonAddress.Name = "tbPersonAddress";
            this.tbPersonAddress.Size = new System.Drawing.Size(417, 73);
            this.tbPersonAddress.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(176, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 29);
            this.label12.TabIndex = 97;
            this.label12.Text = "ที่อยู่";
            // 
            // tbPersonBirthday
            // 
            this.tbPersonBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonBirthday.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonBirthday.Location = new System.Drawing.Point(399, 201);
            this.tbPersonBirthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonBirthday.Name = "tbPersonBirthday";
            this.tbPersonBirthday.Size = new System.Drawing.Size(201, 37);
            this.tbPersonBirthday.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(392, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 94;
            this.label7.Text = "กลุ่มผู้ต้องหา";
            // 
            // tbPersonGroup
            // 
            this.tbPersonGroup.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonGroup.Location = new System.Drawing.Point(399, 400);
            this.tbPersonGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonGroup.Name = "tbPersonGroup";
            this.tbPersonGroup.Size = new System.Drawing.Size(201, 37);
            this.tbPersonGroup.TabIndex = 84;
            // 
            // tbPersonLastname
            // 
            this.tbPersonLastname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonLastname.Location = new System.Drawing.Point(299, 116);
            this.tbPersonLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonLastname.Name = "tbPersonLastname";
            this.tbPersonLastname.Size = new System.Drawing.Size(144, 37);
            this.tbPersonLastname.TabIndex = 80;
            // 
            // tbPersonPhone
            // 
            this.tbPersonPhone.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonPhone.Location = new System.Drawing.Point(183, 400);
            this.tbPersonPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonPhone.Name = "tbPersonPhone";
            this.tbPersonPhone.Size = new System.Drawing.Size(205, 37);
            this.tbPersonPhone.TabIndex = 83;
            // 
            // tbPersonFirstname
            // 
            this.tbPersonFirstname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonFirstname.Location = new System.Drawing.Point(449, 116);
            this.tbPersonFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonFirstname.Name = "tbPersonFirstname";
            this.tbPersonFirstname.Size = new System.Drawing.Size(149, 37);
            this.tbPersonFirstname.TabIndex = 81;
            // 
            // tbPersonCard
            // 
            this.tbPersonCard.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonCard.Location = new System.Drawing.Point(187, 201);
            this.tbPersonCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonCard.Name = "tbPersonCard";
            this.tbPersonCard.Size = new System.Drawing.Size(201, 37);
            this.tbPersonCard.TabIndex = 82;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(395, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 29);
            this.label14.TabIndex = 92;
            this.label14.Text = "วันเกิด";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(299, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 29);
            this.label17.TabIndex = 89;
            this.label17.Text = "ชื่อ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(180, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 29);
            this.label15.TabIndex = 91;
            this.label15.Text = "เลขประชาชนประจำตัว";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(443, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 29);
            this.label16.TabIndex = 90;
            this.label16.Text = "นามสกุล";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(176, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 96;
            this.label9.Text = "เบอร์โทรศัพท์";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(180, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 105;
            this.label2.Text = "คำนำหน้า";
            // 
            // openFileDialog_Person
            // 
            this.openFileDialog_Person.FileName = "openFileDialog1";
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 730);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPersonForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Person)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pictureBox_Person;
        private System.Windows.Forms.TextBox tbPersonAddress;
        private System.Windows.Forms.DateTimePicker tbPersonBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPersonGroup;
        private System.Windows.Forms.TextBox tbPersonLastname;
        private System.Windows.Forms.TextBox tbPersonPhone;
        private System.Windows.Forms.TextBox tbPersonFirstname;
        private System.Windows.Forms.TextBox tbPersonCard;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Person;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPersonTitle;
        private System.Windows.Forms.Label label2;
    }
}