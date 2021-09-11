using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();


            while (input != "end")
            {
                string[] student = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string course = student[0];
                string name = student[1];

                if (students.ContainsKey(course))
                {
                    students[course].Add(name);
                }
                else
                {
                    students.Add(course, new List<string>() { name });
                }
                input = Console.ReadLine();
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"--{name}");
                }
            }
        }
    }
}
