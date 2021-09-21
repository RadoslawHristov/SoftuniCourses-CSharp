using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            string[] resars = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries ); 
            string leterOfname = @"[A-Za-z]+";
            string sumOfpoints =@"[0-9]";

            string input = Console.ReadLine();
            
            foreach (var item in resars)
            {
                results.Add(item,0);
            }
            while (input != "end of race")
            {
                MatchCollection name = Regex.Matches(input, leterOfname);
                MatchCollection digit = Regex.Matches(input, sumOfpoints);
                string sb = String.Empty;
                int sum = 0;
                foreach (Match item in name)
                {
                    sb += item.Value;
                }
                foreach (Match item in digit)
                {
                    sum += int.Parse(item.Value);
                }

                if (!results.ContainsKey(sb))
                {
                    input = Console.ReadLine();
                    continue;
                }
                results[sb] += sum;
                input = Console.ReadLine();
            }

            int count = 1;
            foreach (var item in results.OrderByDescending(x=>x.Value))
            {
                if (count==1)
                {
                     Console.WriteLine($"1st place: {item.Key}");
                }
                else if (count==2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (count==3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }

                count++;
            }
        }
    }
}
