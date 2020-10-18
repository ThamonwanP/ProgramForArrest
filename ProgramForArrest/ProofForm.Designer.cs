namespace ProgramForArrest
{
    partial class ProofForm
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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Persons = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.Font = new System.Drawing.Font("Anantason SemiExpanded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(701, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(42, 54);
            this.btClose.TabIndex = 107;
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason SemiExpanded", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 54);
            this.label1.TabIndex = 108;
            this.label1.Text = "หลักฐาน";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView_Persons);
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
            this.panel1.Location = new System.Drawing.Point(27, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 557);
            this.panel1.TabIndex = 106;
            // 
            // pictureBox_Finger
            // 
            this.pictureBox_Finger.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Finger.Location = new System.Drawing.Point(538, 29);
            this.pictureBox_Finger.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Finger.Name = "pictureBox_Finger";
            this.pictureBox_Finger.Size = new System.Drawing.Size(156, 163);
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "วันที่";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "รายละเอียด";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 290;
            // 
            // listView_Persons
            // 
            this.listView_Persons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView_Persons.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Persons.GridLines = true;
            this.listView_Persons.HideSelection = false;
            this.listView_Persons.Location = new System.Drawing.Point(34, 207);
            this.listView_Persons.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Persons.Name = "listView_Persons";
            this.listView_Persons.Size = new System.Drawing.Size(396, 316);
            this.listView_Persons.TabIndex = 110;
            this.listView_Persons.UseCompatibleStateImageBehavior = false;
            this.listView_Persons.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(447, 266);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anantason SemiExpanded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 112;
            this.label2.Text = "ภาพหลักฐาน";
            // 
            // ProofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 626);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProofForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProofForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Finger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView_Persons;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}