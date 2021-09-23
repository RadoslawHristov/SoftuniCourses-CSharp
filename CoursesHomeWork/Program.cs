using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> averageprice = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!averageprice.ContainsKey(name))
                {
                    averageprice.Add(name,new List<double>());
                    averageprice[name].Add(grade);
                }
                else
                {
                    averageprice[name].Add(grade);
                }
            }
            foreach (var kvp in averageprice.Where(x => x.Value.Average(x => x) >= 4.50).OrderByDescending(y => y.Value.Average(z => z)))
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value.Average(x => x)):f2}");
            }

        }
    }
}
