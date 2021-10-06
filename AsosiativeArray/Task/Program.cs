using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> courseandPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> corseNameAndpoint = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] courses = input.Split(":");
                if (!courseandPassword.ContainsKey(courses[0]))
                {
                    courseandPassword.Add(courses[0], courses[1]);
                }

                input = Console.ReadLine();
            }

            string points = Console.ReadLine();

            while (points != "end of submissions")
            {
                string[] corpoints = points.Split("=>");
                string courses = corpoints[0];
                string pasww = corpoints[1];
                string names = corpoints[2];
                int point = int.Parse(corpoints[3]);

                if (courseandPassword.ContainsKey(courses) && courseandPassword.ContainsValue(pasww))
                {
                    if (!corseNameAndpoint.ContainsKey(names))
                    {
                        corseNameAndpoint.Add(names, new Dictionary<string, int>());
                        corseNameAndpoint[names].Add(courses, point);
                    }

                    if (corseNameAndpoint[names].ContainsKey(courses))
                    {
                        if (corseNameAndpoint[names][courses] < point)
                        {
                            corseNameAndpoint[names][courses] = point;
                        }
                    }
                    else
                    {
                        corseNameAndpoint[names].Add(courses, point);
                    }
                }

                points = Console.ReadLine();
            }

            Dictionary<string, int> totalpointuser = new Dictionary<string, int>();

            foreach (var item in corseNameAndpoint)
            {
                totalpointuser[item.Key] = item.Value.Values.Sum();
            }

            string bestname = totalpointuser.Keys.Max();
            int bestpoint = totalpointuser.Values.Max();

            foreach (var item in totalpointuser)
            {
                if (item.Value == bestpoint)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {item.Value} points.");
                }
            }

            Console.WriteLine("Ranking: ");
            foreach (var item in corseNameAndpoint.OrderBy(x=>x.Key))
            {
                Dictionary<string, int> best = item.Value;
                best = best.OrderBy(x => x.Key).ToDictionary(x =>x.Key,x =>x.Value);
                Console.WriteLine(item.Key);
                
                foreach (var items in best.OrderByDescending(x=>x.Value))
                {
                    
                    Console.WriteLine($"#  {items.Key} -> {items.Value}");
                }
            }
        }
    }
}
