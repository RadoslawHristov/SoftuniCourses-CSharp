﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> studentsByPoints = new Dictionary<string, decimal>();

            Dictionary<string, int> coursesBySubmission = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] parts = line.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string username = parts[0];
                string language = parts[1];
                //decimal points = decimal.Parse(parts[2]);
                // Will throw exception if input does not contain points ("Kiro-banned")

                // Check if language contains "banned" before continuing
                // with remaining code
                if (language == "banned")
                {
                    studentsByPoints.Remove(username);
                    continue;
                }

                if (!studentsByPoints.ContainsKey(username))
                {
                    decimal points = decimal.Parse(parts[2]);
                    studentsByPoints.Add(username, points);

                    if (!coursesBySubmission.ContainsKey(language))
                    {
                        coursesBySubmission.Add(language, 1);
                    }
                    else
                    {
                        coursesBySubmission[language] += 1;
                    }
                }
                else
                {
                    decimal points = decimal.Parse(parts[2]);

                    if (studentsByPoints[username] <= points)
                    {
                        studentsByPoints[username] = points;
                    }

                    coursesBySubmission[language] += 1;
                }

                //if (language == "banned")
                //{
                //    studentsByPoints.Remove(username);
                //}
            }

            Dictionary<string, decimal> sortedByPoints = studentsByPoints
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            //foreach (var kvp in sortedByPoints)
            // Alternative for kvp
            foreach (var (student, grade) in sortedByPoints)
            {
                //Console.WriteLine($"{kvp.Key} | {kvp.Value}")
                Console.WriteLine($"{student} | {grade}");
            }

            Dictionary<string, int> sortedBySubmissions = coursesBySubmission
                .Where(s => s.Value > 0)
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            //foreach (var kvp in sortedBySubmissions)
            // Alternative for kvp
            foreach (var (lang, count) in sortedBySubmissions)
            {
                //Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                Console.WriteLine($"{lang} - {count}");
            }
        }
    }
}