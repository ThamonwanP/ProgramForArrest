namespace ProgramForArrest
{
    partial class AddFingerprintForm
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
            this.listView_Persons = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btSeach = new System.Windows.Forms.Button();
            this.btScan = new System.Windows.Forms.Button();
            this.btAddFingerPrint = new System.Windows.Forms.Button();
            this.pictureBox_Finger = new System.Windows.Forms.PictureBox();
            this.tbPersonGroup = new System.Windows.Forms.TextBox();
            this.tbUserLastname = new System.Windows.Forms.TextBox();
            this.tbPersonPhone = new System.Windows.Forms.TextBox();
            this.tbPersonFirstname = new System.Windows.Forms.TextBox();
            this.tbPersonCard = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.Font = new System.Drawing.Font("Anantason SemiExpanded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(703, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(42, 54);
            this.btClose.TabIndex = 104;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason SemiExpanded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 54);
            this.label1.TabIndex = 105;
            this.label1.Text = "ข้อมูลลายนิ้วมือ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listView_Persons);
            this.panel1.Controls.Add(this.groupBox9);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.btAddFingerPrint);
            this.panel1.Controls.Add(this.pictureBox_Finger);
            this.panel1.Controls.Add(this.tbPersonGroup);
            this.panel1.Controls.Add(this.tbUserLastname);
            this.panel1.Controls.Add(this.tbPersonPhone);
            this.panel1.Controls.Add(this.tbPersonFirstname);
            this.panel1.Controls.Add(this.tbPersonCard);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(29, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 557);
            this.panel1.TabIndex = 103;
            // 
            // listView_Persons
            // 
            this.listView_Persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_Persons.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Persons.GridLines = true;
            this.listView_Persons.HideSelection = false;
            this.listView_Persons.Location = new System.Drawing.Point(34, 207);
            this.listView_Persons.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Persons.Name = "listView_Persons";
            this.listView_Persons.Size = new System.Drawing.Size(476, 275);
            this.listView_Persons.TabIndex = 110;
            this.listView_Persons.UseCompatibleStateImageBehavior = false;
            this.listView_Persons.View = System.Windows.Forms.View.Details;
            this.listView_Persons.SelectedIndexChanged += new System.EventHandler(this.listView_Persons_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "เลขประชาชนประจำตัว";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ชื่อ";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "นามสกุล";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "กลุ่มผู้ต้องหา";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 125;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioLeft);
            this.groupBox9.Controls.Add(this.radioRight);
            this.groupBox9.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(534, 207);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(160, 119);
            this.groupBox9.TabIndex = 109;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "รายละเอียดลายนิ้วมือ";
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Location = new System.Drawing.Point(37, 33);
            this.radioLeft.Margin = new System.Windows.Forms.Padding(2);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(79, 30);
            this.radioLeft.TabIndex = 28;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "ด้านซ้าย";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(37, 63);
            this.radioRight.Margin = new System.Windows.Forms.Padding(2);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(79, 30);
            this.radioRight.TabIndex = 29;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "ด้านขวา";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btSeach);
            this.groupBox7.Controls.Add(this.btScan);
            this.groupBox7.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(534, 346);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(160, 136);
            this.groupBox7.TabIndex = 108;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "จัดการลายนิ้วมือ";
            // 
            // btSeach
            // 
            this.btSeach.Location = new System.Drawing.Point(18, 95);
            this.btSeach.Margin = new System.Windows.Forms.Padding(2);
            this.btSeach.Name = "btSeach";
            this.btSeach.Size = new System.Drawing.Size(125, 31);
            this.btSeach.TabIndex = 30;
            this.btSeach.Text = "ค้นหาลายนิ้วมือ";
            this.btSeach.UseVisualStyleBackColor = true;
            // 
            // btScan
            // 
            this.btScan.Location = new System.Drawing.Point(18, 46);
            this.btScan.Margin = new System.Windows.Forms.Padding(2);
            this.btScan.Name = "btScan";
            this.btScan.Size = new System.Drawing.Size(125, 31);
            this.btScan.TabIndex = 26;
            this.btScan.Text = "สแกนลายนิ้วมือ";
            this.btScan.UseVisualStyleBackColor = true;
            this.btScan.Click += new System.EventHandler(this.btScan_Click);
            // 
            // btAddFingerPrint
            // 
            this.btAddFingerPrint.Font = new System.Drawing.Font("Anantason SemiExpanded", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddFingerPrint.Location = new System.Drawing.Point(170, 500);
            this.btAddFingerPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btAddFingerPrint.Name = "btAddFingerPrint";
            this.btAddFingerPrint.Size = new System.Drawing.Size(218, 36);
            this.btAddFingerPrint.TabIndex = 102;
            this.btAddFingerPrint.Text = "บันทึกลงฐานข้อมูล";
            this.btAddFingerPrint.UseVisualStyleBackColor = true;
            this.btAddFingerPrint.Click += new System.EventHandler(this.btAddFingerPrint_Click);
            // 
            // pictureBox_Finger
            // 
            this.pictureBox_Finger.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Finger.Location = new System.Drawing.Point(545, 29);
            this.pictureBox_Finger.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Finger.Name = "pictureBox_Finger";
            this.pictureBox_Finger.Size = new System.Drawing.Size(149, 163);
            this.pictureBox_Finger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Finger.TabIndex = 101;
            this.pictureBox_Finger.TabStop = false;
            // 
            // tbPersonGroup
            // 
            this.tbPersonGroup.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonGroup.Location = new System.Drawing.Point(38, 145);
            this.tbPersonGroup.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersonGroup.Name = "tbPersonGroup";
            this.tbPersonGroup.ReadOnly = true;
            this.tbPersonGroup.Size = new System.Drawing.Size(225, 34);
            this.tbPersonGroup.TabIndex = 84;
            // 
            // tbUserLastname
            // 
            this.tbUserLastname.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserLastname.Location = new System.Drawing.Point(358, 74);
            this.tbUserLastname.Margin = new System.Windows.Forms.Padding(2);
            this.tbUserLastname.Name = "tbUserLastname";
            this.tbUserLastname.ReadOnly = true;
            this.tbUserLastname.Size = new System.Drawing.Size(152, 34);
            this.tbUserLastname.TabIndex = 80;
            // 
            // tbPersonPhone
            // 
            this.tbPersonPhone.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonPhone.Location = new System.Drawing.Point(267, 145);
            this.tbPersonPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersonPhone.Name = "tbPersonPhone";
            this.tbPersonPhone.ReadOnly = true;
            this.tbPersonPhone.Size = new System.Drawing.Size(243, 34);
            this.tbPersonPhone.TabIndex = 83;
            // 
            // tbPersonFirstname
            // 
            this.tbPersonFirstname.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonFirstname.Location = new System.Drawing.Point(199, 74);
            this.tbPersonFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersonFirstname.Name = "tbPersonFirstname";
            this.tbPersonFirstname.ReadOnly = true;
            this.tbPersonFirstname.Size = new System.Drawing.Size(152, 34);
            this.tbPersonFirstname.TabIndex = 81;
            // 
            // tbPersonCard
            // 
            this.tbPersonCard.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonCard.Location = new System.Drawing.Point(38, 74);
            this.tbPersonCard.Margin = new System.Windows.Forms.Padding(2);
            this.tbPersonCard.Name = "tbPersonCard";
            this.tbPersonCard.ReadOnly = true;
            this.tbPersonCard.Size = new System.Drawing.Size(152, 34);
            this.tbPersonCard.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(196, 52);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 26);
            this.label17.TabIndex = 89;
            this.label17.Text = "ชื่อ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 26);
            this.label15.TabIndex = 91;
            this.label15.Text = "เลขประชาชนประจำตัว";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(353, 49);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 26);
            this.label16.TabIndex = 90;
            this.label16.Text = "นามสกุล";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 26);
            this.label9.TabIndex = 96;
            this.label9.Text = "เบอร์โทรศัพท์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 94;
            this.label7.Text = "กลุ่มผู้ต้องหา";
            // 
            // AddFingerprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 626);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFingerprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFingerprintForm";
            this.Load += new System.EventHandler(this.AddFingerprintForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAddFingerPrint;
        private System.Windows.Forms.PictureBox pictureBox_Finger;
        private System.Windows.Forms.TextBox tbPersonGroup;
        private System.Windows.Forms.TextBox tbUserLastname;
        private System.Windows.Forms.TextBox tbPersonPhone;
        private System.Windows.Forms.TextBox tbPersonFirstname;
        private System.Windows.Forms.TextBox tbPersonCard;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.Button btSeach;
        private System.Windows.Forms.Button btScan;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListView listView_Persons;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}