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
}
