using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                // Add student logic
                string studentID = txtStudentID.Text;
                string name = txtStudentName.Text;
                string major = txtStudentMajor.Text;
                if (!double.TryParse(txtStudentGrade.Text, out double grade))
                {
                    MessageBox.Show("Invalid grade format.");
                    return;
                }

                Student student = new Student(studentID, name, major, grade);
                AddStudent(student);

                // Optionally, associate with an advisor
                string advisorName = txtAdvisorName.Text;
                Advisor advisor = advisors.Find(a => a.Name == advisorName);
                if (advisor != null)
                {
                    advisor.AddStudent(student);
                }

                MessageBox.Show("Student added");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }

        private void btnShowHighestGradeStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student highestGradeStudent = WindowsFormsApp1.Student.GetHighestGradeStudent(students);
                if (highestGradeStudent != null)
                {
                    MessageBox.Show($"Highest Grade Student:\nID: {highestGradeStudent.StudentID}\nName: {highestGradeStudent.Name}\nMajor: {highestGradeStudent.Major}\nGrade: {highestGradeStudent.Grade}");
                }
                else
                {
                    MessageBox.Show("No students available.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No students available.");
                return;
            }

            StringBuilder studentInfo = new StringBuilder();
            foreach (var student in students)
            {
                studentInfo.AppendLine($"ID: {student.StudentID}, Name: {student.Name}, Major: {student.Major}, Grade: {student.Grade}");
            }

            MessageBox.Show(studentInfo.ToString(), "All Students");
        }

        private void AddStudent(Student student)
        {
            students.Add(student);
        }

        private void AddAdvisor(Advisor advisor)
        {
            advisors.Add(advisor);
        }
    }
}
