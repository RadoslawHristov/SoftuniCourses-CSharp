using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userCourpoint =
                new Dictionary<string, Dictionary<string, int>>();


            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] courses = input.Split("->");
                string user = courses[0];
                string course = courses[1];
                int point = int.Parse(courses[2]);

                if (!userCourpoint.ContainsKey(course))
                {
                    userCourpoint.Add(course, new Dictionary<string, int>());
                    userCourpoint[course].Add(user, point);
                }
                else
                {
                    if (userCourpoint.ContainsKey(course))
                    {

                        if (!userCourpoint.ContainsKey(user))
                        {
                            userCourpoint[course].Add(user, point);
                        }
                        else
                        {
                            if (userCourpoint[user][course] < point)
                            {
                                userCourpoint[user][course] = point;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in userCourpoint)
            {
                Dictionary<string, int> nested2 = kvp.Value;
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                int counter = 1;

                foreach (var pair in nested2.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
                {

                    Console.WriteLine($"{counter++}. {pair.Key} <::> {pair.Value}");
                }
            }
            Dictionary<string, int> totalpointuser = new Dictionary<string, int>();
            foreach (var item in userCourpoint)
            {
                totalpointuser[item.Key] = item.Value.Values.Sum();
            }
            Console.WriteLine("Individual standings:");
            int count = 0;
            foreach (var item in totalpointuser.OrderByDescending(x=>x.Value))
            {
                count++;
                Console.WriteLine($"{count}. {item.Key} -> {item.Value} ");
            }
        }
    }
}
