using System;
using System.Collections.Generic;

namespace Student2._0
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Town { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (input != "end")
            {
                string[] line = input.Split();

                string first = line[0];
                string last = line[1];
                int age = int.Parse(line[2]);
                string town = line[3];
                if (StudentExisting(students,first,last))
                {
                    Student student = GetStudent(students, first, last);

                    student.FirstName = first;
                    student.LastName = last;
                    student.Age = age;
                    student.Town = town;
                }
                else
                {
                    Student student = new Student();
                    {
                        student.FirstName = first;
                        student.LastName = last;
                        student.Age = age;
                        student.Town = town;
                    }
                    students.Add(student);
                }
                
                input = Console.ReadLine();
            }

            string filteredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Town == filteredCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static Student GetStudent(List<Student> students, string first, string last)
        {
            Student studentExisting = null;
            foreach (Student student in students)
            {
                if (student.FirstName==first && student.LastName==last)
                {
                    studentExisting = student;
                } 
            }

            return studentExisting;
        }

        static bool StudentExisting(List<Student> students, string first, string last)
        {
            foreach (Student student in students)
            {
                if (student.FirstName==first && student.LastName==last)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
