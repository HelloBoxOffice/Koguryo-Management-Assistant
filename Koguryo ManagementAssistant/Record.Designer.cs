namespace Koguryo_ManagementAssistant
{
    partial class Record
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
            this.studentlist = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentfirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentlastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentfnamebox = new System.Windows.Forms.TextBox();
            this.studentlnamebox = new System.Windows.Forms.TextBox();
            this.addstudentbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedfname = new System.Windows.Forms.TextBox();
            this.selectedlname = new System.Windows.Forms.TextBox();
            this.dateStamp = new System.Windows.Forms.DateTimePicker();
            this.classbox = new System.Windows.Forms.ComboBox();
            this.paidbox = new System.Windows.Forms.CheckBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.attendancebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentlist
            // 
            this.studentlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentfirstname,
            this.studentlastname});
            this.studentlist.FullRowSelect = true;
            this.studentlist.HideSelection = false;
            this.studentlist.Location = new System.Drawing.Point(13, 13);
            this.studentlist.MultiSelect = false;
            this.studentlist.Name = "studentlist";
            this.studentlist.Size = new System.Drawing.Size(404, 400);
            this.studentlist.TabIndex = 0;
            this.studentlist.UseCompatibleStateImageBehavior = false;
            this.studentlist.View = System.Windows.Forms.View.Details;
            this.studentlist.SelectedIndexChanged += new System.EventHandler(this.studentlist_SelectedIndexChanged);
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentfirstname
            // 
            this.studentfirstname.Text = "Firstname";
            this.studentfirstname.Width = 139;
            // 
            // studentlastname
            // 
            this.studentlastname.Text = "Lastname";
            this.studentlastname.Width = 201;
            // 
            // studentfnamebox
            // 
            this.studentfnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentfnamebox.Location = new System.Drawing.Point(69, 25);
            this.studentfnamebox.Name = "studentfnamebox";
            this.studentfnamebox.Size = new System.Drawing.Size(100, 20);
            this.studentfnamebox.TabIndex = 1;
            this.studentfnamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // studentlnamebox
            // 
            this.studentlnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlnamebox.Location = new System.Drawing.Point(69, 62);
            this.studentlnamebox.Name = "studentlnamebox";
            this.studentlnamebox.Size = new System.Drawing.Size(100, 20);
            this.studentlnamebox.TabIndex = 2;
            this.studentlnamebox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addstudentbtn
            // 
            this.addstudentbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudentbtn.Location = new System.Drawing.Point(11, 98);
            this.addstudentbtn.Name = "addstudentbtn";
            this.addstudentbtn.Size = new System.Drawing.Size(75, 23);
            this.addstudentbtn.TabIndex = 3;
            this.addstudentbtn.Text = "Add Student";
            this.addstudentbtn.UseVisualStyleBackColor = true;
            this.addstudentbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // selectedfname
            // 
            this.selectedfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedfname.Location = new System.Drawing.Point(83, 60);
            this.selectedfname.Name = "selectedfname";
            this.selectedfname.Size = new System.Drawing.Size(100, 20);
            this.selectedfname.TabIndex = 7;
            // 
            // selectedlname
            // 
            this.selectedlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedlname.Location = new System.Drawing.Point(83, 89);
            this.selectedlname.Name = "selectedlname";
            this.selectedlname.Size = new System.Drawing.Size(100, 20);
            this.selectedlname.TabIndex = 8;
            // 
            // dateStamp
            // 
            this.dateStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStamp.Location = new System.Drawing.Point(83, 116);
            this.dateStamp.Name = "dateStamp";
            this.dateStamp.Size = new System.Drawing.Size(133, 20);
            this.dateStamp.TabIndex = 9;
            this.dateStamp.Value = new System.DateTime(2016, 5, 25, 14, 2, 17, 0);
            // 
            // classbox
            // 
            this.classbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classbox.FormattingEnabled = true;
            this.classbox.Items.AddRange(new object[] {
            "Little Dragons",
            "KFMAS Tigers",
            "Adults",
            "Weapons",
            "Bagblast",
            "Women\'s Kick Fit"});
            this.classbox.Location = new System.Drawing.Point(83, 143);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(121, 21);
            this.classbox.TabIndex = 10;
            // 
            // paidbox
            // 
            this.paidbox.AutoSize = true;
            this.paidbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidbox.Location = new System.Drawing.Point(83, 171);
            this.paidbox.Name = "paidbox";
            this.paidbox.Size = new System.Drawing.Size(69, 17);
            this.paidbox.TabIndex = 11;
            this.paidbox.Text = "Has Paid";
            this.paidbox.UseVisualStyleBackColor = true;
            // 
            // amountbox
            // 
            this.amountbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountbox.Location = new System.Drawing.Point(83, 195);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(100, 20);
            this.amountbox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Firstname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Amount Paid";
            // 
            // attendancebtn
            // 
            this.attendancebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendancebtn.Location = new System.Drawing.Point(13, 229);
            this.attendancebtn.Name = "attendancebtn";
            this.attendancebtn.Size = new System.Drawing.Size(75, 23);
            this.attendancebtn.TabIndex = 18;
            this.attendancebtn.Text = "Submit";
            this.attendancebtn.UseVisualStyleBackColor = true;
            this.attendancebtn.Click += new System.EventHandler(this.attendancebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Controls.Add(this.attendancebtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.selectedfname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.selectedlname);
            this.groupBox1.Controls.Add(this.dateStamp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.classbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paidbox);
            this.groupBox1.Controls.Add(this.amountbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(427, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 263);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID";
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idbox.Location = new System.Drawing.Point(83, 28);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 20);
            this.idbox.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.studentfnamebox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.studentlnamebox);
            this.groupBox2.Controls.Add(this.addstudentbtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(429, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 131);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Student";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 425);
            this.Controls.Add(this.studentlist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Record";
            this.Text = "Record";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView studentlist;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentfirstname;
        private System.Windows.Forms.ColumnHeader studentlastname;
        private System.Windows.Forms.TextBox studentfnamebox;
        private System.Windows.Forms.TextBox studentlnamebox;
        private System.Windows.Forms.Button addstudentbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox selectedfname;
        private System.Windows.Forms.TextBox selectedlname;
        private System.Windows.Forms.DateTimePicker dateStamp;
        private System.Windows.Forms.ComboBox classbox;
        private System.Windows.Forms.CheckBox paidbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button attendancebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idbox;
    }
}