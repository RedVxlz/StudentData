using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Student
    {
        public string StudentID { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public Advisor Advisor { get; set; }
        public double Grade { get; private set; }

        public Student(string studentID, string name, string major, double grade)
        {
            StudentID = studentID;
            Name = name;
            Major = major;
            Grade = grade;
        }

        public static Student GetHighestGradeStudent(List<Student> students)
        {
            if (students == null || students.Count == 0)
                throw new ArgumentException("empty");

            return students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }
    }

    public class Advisor
    {
        public string Name { get; private set; }
        public string Major { get; private set; }
        private List<Student> students;

        public Advisor(string name, string major)
        {
            Name = name;
            Major = major;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));

            students.Add(student);
            student.Advisor = this;
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void DisplayStudents()
        {
            Console.WriteLine($"Advisor: {Name}, Major: {Major}");
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.StudentID}, Name: {student.Name}, Major: {student.Major}, Grade: {student.Grade}");
            }
        }
    }
}
