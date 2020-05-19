using System;
using System.Collections.Generic;

namespace OopPractice
{
    class Student : IComparable
    {
        public string name = "?";
        public float grade = -1;
        public float age = -1;
        public float income = -1;

        public Student(string name, float grade)
        {
            this.name = name;

            if (name.Length == 0)
            {
                throw new Exception("MISSING NAME!!");
            }

            if (name.Length > 20)
            {
                throw new Exception("NAME TOO LONG!!!");
            }

            this.grade = grade;

            if (grade < 0 || grade > 100)
            {
                throw new Exception("GRADE INVALID!!");
            }
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;

            if (grade == other.grade)
            {
                return name.CompareTo(other.name);
            }
            else
            {
                return grade.CompareTo(other.grade);
            }
        }

        public override string ToString()
        {
            return $"{name}: {grade}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Jack", 100),
                new Student("Sixiang", 100),
                new Student("DCharlie", 80),
                new Student("XAlice", 80),
                new Student("Chenyi", 100),
                new Student("Bob", 80),
                new Student("Vini", 100),
            };
            students.Sort();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
