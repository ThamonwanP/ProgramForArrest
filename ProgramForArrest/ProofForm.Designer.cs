﻿namespace ProgramForArrest
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView_Events = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_Person = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Person)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anantason", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(532, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 68);
            this.label1.TabIndex = 108;
            this.label1.Text = "หลักฐาน";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listView_Events);
            this.panel1.Controls.Add(this.pictureBox_Person);
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
            this.panel1.Location = new System.Drawing.Point(36, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 698);
            this.panel1.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(1048, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 112;
            this.label2.Text = "ภาพหลักฐาน";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(911, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // listView_Events
            // 
            this.listView_Events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6});
            this.listView_Events.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listView_Events.FullRowSelect = true;
            this.listView_Events.GridLines = true;
            this.listView_Events.HideSelection = false;
            this.listView_Events.Location = new System.Drawing.Point(33, 305);
            this.listView_Events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Events.Name = "listView_Events";
            this.listView_Events.Size = new System.Drawing.Size(857, 358);
            this.listView_Events.TabIndex = 110;
            this.listView_Events.UseCompatibleStateImageBehavior = false;
            this.listView_Events.View = System.Windows.Forms.View.Details;
            this.listView_Events.SelectedIndexChanged += new System.EventHandler(this.listView_Events_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "วันที่";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 125;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ชื่อเรื่อง";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "รายละเอียด";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 365;
            // 
            // pictureBox_Person
            // 
            this.pictureBox_Person.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Person.Location = new System.Drawing.Point(33, 78);
            this.pictureBox_Person.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Person.Name = "pictureBox_Person";
            this.pictureBox_Person.Size = new System.Drawing.Size(197, 201);
            this.pictureBox_Person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Person.TabIndex = 101;
            this.pictureBox_Person.TabStop = false;
            // 
            // tbPersonGroup
            // 
            this.tbPersonGroup.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonGroup.Location = new System.Drawing.Point(257, 240);
            this.tbPersonGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonGroup.Name = "tbPersonGroup";
            this.tbPersonGroup.ReadOnly = true;
            this.tbPersonGroup.Size = new System.Drawing.Size(285, 37);
            this.tbPersonGroup.TabIndex = 84;
            // 
            // tbUserLastname
            // 
            this.tbUserLastname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbUserLastname.Location = new System.Drawing.Point(684, 153);
            this.tbUserLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserLastname.Name = "tbUserLastname";
            this.tbUserLastname.ReadOnly = true;
            this.tbUserLastname.Size = new System.Drawing.Size(201, 37);
            this.tbUserLastname.TabIndex = 80;
            // 
            // tbPersonPhone
            // 
            this.tbPersonPhone.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonPhone.Location = new System.Drawing.Point(563, 240);
            this.tbPersonPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonPhone.Name = "tbPersonPhone";
            this.tbPersonPhone.ReadOnly = true;
            this.tbPersonPhone.Size = new System.Drawing.Size(323, 37);
            this.tbPersonPhone.TabIndex = 83;
            // 
            // tbPersonFirstname
            // 
            this.tbPersonFirstname.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonFirstname.Location = new System.Drawing.Point(472, 153);
            this.tbPersonFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonFirstname.Name = "tbPersonFirstname";
            this.tbPersonFirstname.ReadOnly = true;
            this.tbPersonFirstname.Size = new System.Drawing.Size(201, 37);
            this.tbPersonFirstname.TabIndex = 81;
            // 
            // tbPersonCard
            // 
            this.tbPersonCard.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPersonCard.Location = new System.Drawing.Point(257, 153);
            this.tbPersonCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPersonCard.Name = "tbPersonCard";
            this.tbPersonCard.ReadOnly = true;
            this.tbPersonCard.Size = new System.Drawing.Size(201, 37);
            this.tbPersonCard.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.Location = new System.Drawing.Point(468, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 29);
            this.label17.TabIndex = 89;
            this.label17.Text = "ชื่อ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(251, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 29);
            this.label15.TabIndex = 91;
            this.label15.Text = "เลขประชาชนประจำตัว";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(677, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 29);
            this.label16.TabIndex = 90;
            this.label16.Text = "นามสกุล";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(559, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 96;
            this.label9.Text = "เบอร์โทรศัพท์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Anantason", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(251, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 94;
            this.label7.Text = "กลุ่มผู้ต้องหา";
            // 
            // ProofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1364, 773);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProofForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProofForm";
            this.Load += new System.EventHandler(this.ProofForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Person;
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
        private System.Windows.Forms.ListView listView_Events;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}