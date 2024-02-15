using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public static string CourseName;

        public Student()
        {
           // CourseName = "Dot Net";
            Console.WriteLine("Default Constructor Called");
        }

        static Student()
        {
            CourseName = "Dot Net"; // to initalize static fields
            Console.WriteLine("Static Constructor Called");
        }

        public Student(string fn, string ln)
        {
            Console.WriteLine("Parameterized Constructor Called");
            this.FirstName = fn;
            this.LastName = ln;
        }

        public Student(Student s)
        {
            Console.WriteLine("Copy Constructor");
            FirstName = s.FirstName;
            LastName = s.LastName;
        }

        public void Initialize(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void Print()
        {
            Console.WriteLine($"Full Name: {this.FirstName} {this.LastName} - {CourseName}");
        }
    }
}
