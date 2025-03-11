namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdvisorName = new System.Windows.Forms.TextBox();
            this.txtStudentMajor = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentGrade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowHighestGradeStudent = new System.Windows.Forms.Button();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.GroupBox();
            this.Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(386, 44);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(132, 66);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(128, 85);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(150, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Major";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Advisor Name";
            // 
            // txtAdvisorName
            // 
            this.txtAdvisorName.Location = new System.Drawing.Point(128, 214);
            this.txtAdvisorName.Name = "txtAdvisorName";
            this.txtAdvisorName.Size = new System.Drawing.Size(150, 20);
            this.txtAdvisorName.TabIndex = 6;
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(128, 168);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(150, 20);
            this.txtStudentMajor.TabIndex = 7;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(128, 126);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(150, 20);
            this.txtStudentID.TabIndex = 8;
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(128, 45);
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.Size = new System.Drawing.Size(150, 20);
            this.txtStudentGrade.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Student Grade";
            // 
            // btnShowHighestGradeStudent
            // 
            this.btnShowHighestGradeStudent.Location = new System.Drawing.Point(386, 134);
            this.btnShowHighestGradeStudent.Name = "btnShowHighestGradeStudent";
            this.btnShowHighestGradeStudent.Size = new System.Drawing.Size(132, 66);
            this.btnShowHighestGradeStudent.TabIndex = 18;
            this.btnShowHighestGradeStudent.Text = "Show Highest grade";
            this.btnShowHighestGradeStudent.UseVisualStyleBackColor = true;
            this.btnShowHighestGradeStudent.Click += new System.EventHandler(this.btnShowHighestGradeStudent_Click);
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Location = new System.Drawing.Point(386, 222);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(132, 66);
            this.btnShowAllStudents.TabIndex = 19;
            this.btnShowAllStudents.Text = "Show List Students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // Student
            // 
            this.Student.Controls.Add(this.txtStudentMajor);
            this.Student.Controls.Add(this.txtStudentName);
            this.Student.Controls.Add(this.label1);
            this.Student.Controls.Add(this.label7);
            this.Student.Controls.Add(this.label2);
            this.Student.Controls.Add(this.txtStudentGrade);
            this.Student.Controls.Add(this.label3);
            this.Student.Controls.Add(this.txtStudentID);
            this.Student.Controls.Add(this.label4);
            this.Student.Controls.Add(this.txtAdvisorName);
            this.Student.Location = new System.Drawing.Point(48, 22);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(312, 281);
            this.Student.TabIndex = 20;
            this.Student.TabStop = false;
            this.Student.Text = "Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 332);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.btnShowHighestGradeStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Student.ResumeLayout(false);
            this.Student.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdvisorName;
        private System.Windows.Forms.TextBox txtStudentMajor;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShowHighestGradeStudent;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.GroupBox Student;
    }
}