namespace WindowsFormsApplication
{
    partial class PersonDetailsForm
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
            this.createStudentButton = new System.Windows.Forms.Button();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.studentSubjectTextBox = new System.Windows.Forms.TextBox();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.class5TextBox = new System.Windows.Forms.TextBox();
            this.class4TextBox = new System.Windows.Forms.TextBox();
            this.class3TextBox = new System.Windows.Forms.TextBox();
            this.class2TextBox = new System.Windows.Forms.TextBox();
            this.class1TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teacherSubjectTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createTeacherButton = new System.Windows.Forms.Button();
            this.saveTeacherButton = new System.Windows.Forms.Button();
            this.viewPersonButton = new System.Windows.Forms.Button();
            this.dobMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contactMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // createStudentButton
            // 
            this.createStudentButton.Location = new System.Drawing.Point(505, 283);
            this.createStudentButton.Name = "createStudentButton";
            this.createStudentButton.Size = new System.Drawing.Size(128, 27);
            this.createStudentButton.TabIndex = 3;
            this.createStudentButton.Text = "Create Student";
            this.createStudentButton.UseVisualStyleBackColor = true;
            this.createStudentButton.Click += new System.EventHandler(this.createStudentButton_Click);
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.Location = new System.Drawing.Point(505, 316);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(128, 27);
            this.saveStudentButton.TabIndex = 4;
            this.saveStudentButton.Text = "Save Student";
            this.saveStudentButton.UseVisualStyleBackColor = true;
            this.saveStudentButton.Click += new System.EventHandler(this.saveStudentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.studentSubjectTextBox);
            this.groupBox1.Controls.Add(this.classTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(430, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Class";
            // 
            // studentSubjectTextBox
            // 
            this.studentSubjectTextBox.Location = new System.Drawing.Point(94, 19);
            this.studentSubjectTextBox.Name = "studentSubjectTextBox";
            this.studentSubjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentSubjectTextBox.TabIndex = 23;
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(94, 45);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Subject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.class5TextBox);
            this.groupBox2.Controls.Add(this.class4TextBox);
            this.groupBox2.Controls.Add(this.class3TextBox);
            this.groupBox2.Controls.Add(this.class2TextBox);
            this.groupBox2.Controls.Add(this.class1TextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.teacherSubjectTextBox);
            this.groupBox2.Controls.Add(this.salaryTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(221, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 239);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teacher Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Classes";
            // 
            // class5TextBox
            // 
            this.class5TextBox.Location = new System.Drawing.Point(97, 175);
            this.class5TextBox.Name = "class5TextBox";
            this.class5TextBox.Size = new System.Drawing.Size(100, 20);
            this.class5TextBox.TabIndex = 30;
            // 
            // class4TextBox
            // 
            this.class4TextBox.Location = new System.Drawing.Point(97, 149);
            this.class4TextBox.Name = "class4TextBox";
            this.class4TextBox.Size = new System.Drawing.Size(100, 20);
            this.class4TextBox.TabIndex = 29;
            // 
            // class3TextBox
            // 
            this.class3TextBox.Location = new System.Drawing.Point(97, 123);
            this.class3TextBox.Name = "class3TextBox";
            this.class3TextBox.Size = new System.Drawing.Size(100, 20);
            this.class3TextBox.TabIndex = 28;
            // 
            // class2TextBox
            // 
            this.class2TextBox.Location = new System.Drawing.Point(97, 97);
            this.class2TextBox.Name = "class2TextBox";
            this.class2TextBox.Size = new System.Drawing.Size(100, 20);
            this.class2TextBox.TabIndex = 27;
            // 
            // class1TextBox
            // 
            this.class1TextBox.Location = new System.Drawing.Point(97, 71);
            this.class1TextBox.Name = "class1TextBox";
            this.class1TextBox.Size = new System.Drawing.Size(100, 20);
            this.class1TextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Salary";
            // 
            // teacherSubjectTextBox
            // 
            this.teacherSubjectTextBox.Location = new System.Drawing.Point(97, 19);
            this.teacherSubjectTextBox.Name = "teacherSubjectTextBox";
            this.teacherSubjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherSubjectTextBox.TabIndex = 23;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(97, 45);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Subject";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contactMaskedTextBox);
            this.groupBox3.Controls.Add(this.dobMaskedTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.addressTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.idTextBox);
            this.groupBox3.Controls.Add(this.nameTextBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 239);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(97, 71);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 72);
            this.addressTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(97, 19);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 45);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Id";
            // 
            // createTeacherButton
            // 
            this.createTeacherButton.Location = new System.Drawing.Point(296, 283);
            this.createTeacherButton.Name = "createTeacherButton";
            this.createTeacherButton.Size = new System.Drawing.Size(128, 27);
            this.createTeacherButton.TabIndex = 32;
            this.createTeacherButton.Text = "Create Teacher";
            this.createTeacherButton.UseVisualStyleBackColor = true;
            this.createTeacherButton.Click += new System.EventHandler(this.createTeacherButton_Click);
            // 
            // saveTeacherButton
            // 
            this.saveTeacherButton.Location = new System.Drawing.Point(296, 316);
            this.saveTeacherButton.Name = "saveTeacherButton";
            this.saveTeacherButton.Size = new System.Drawing.Size(128, 27);
            this.saveTeacherButton.TabIndex = 33;
            this.saveTeacherButton.Text = "Save Teacher";
            this.saveTeacherButton.UseVisualStyleBackColor = true;
            this.saveTeacherButton.Click += new System.EventHandler(this.saveTeacherButton_Click);
            // 
            // viewPersonButton
            // 
            this.viewPersonButton.Location = new System.Drawing.Point(87, 283);
            this.viewPersonButton.Name = "viewPersonButton";
            this.viewPersonButton.Size = new System.Drawing.Size(128, 27);
            this.viewPersonButton.TabIndex = 34;
            this.viewPersonButton.Text = "View";
            this.viewPersonButton.UseVisualStyleBackColor = true;
            this.viewPersonButton.Click += new System.EventHandler(this.viewPersonButton_Click);
            // 
            // dobMaskedTextBox
            // 
            this.dobMaskedTextBox.Location = new System.Drawing.Point(97, 149);
            this.dobMaskedTextBox.Mask = "00/00/0000";
            this.dobMaskedTextBox.Name = "dobMaskedTextBox";
            this.dobMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.dobMaskedTextBox.TabIndex = 26;
            this.dobMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // contactMaskedTextBox
            // 
            this.contactMaskedTextBox.Location = new System.Drawing.Point(97, 175);
            this.contactMaskedTextBox.Mask = "00000000";
            this.contactMaskedTextBox.Name = "contactMaskedTextBox";
            this.contactMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactMaskedTextBox.TabIndex = 34;
            // 
            // PersonDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 451);
            this.Controls.Add(this.viewPersonButton);
            this.Controls.Add(this.saveTeacherButton);
            this.Controls.Add(this.createTeacherButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.createStudentButton);
            this.Name = "PersonDetailsForm";
            this.Text = "U42 Programming in .Net";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button createStudentButton;
        internal System.Windows.Forms.Button saveStudentButton;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox studentSubjectTextBox;
        internal System.Windows.Forms.TextBox classTextBox;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox class5TextBox;
        internal System.Windows.Forms.TextBox class4TextBox;
        internal System.Windows.Forms.TextBox class3TextBox;
        internal System.Windows.Forms.TextBox class2TextBox;
        internal System.Windows.Forms.TextBox class1TextBox;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox teacherSubjectTextBox;
        internal System.Windows.Forms.TextBox salaryTextBox;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox addressTextBox;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button createTeacherButton;
        internal System.Windows.Forms.Button saveTeacherButton;
        internal System.Windows.Forms.Button viewPersonButton;
        internal System.Windows.Forms.TextBox idTextBox;
        internal System.Windows.Forms.MaskedTextBox dobMaskedTextBox;
        internal System.Windows.Forms.MaskedTextBox contactMaskedTextBox;
    }
}

