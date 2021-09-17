using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] comamd = input.Split();
                double price = double.Parse(comamd[1]);
                double quantity = double.Parse(comamd[2]);

                if (!products.ContainsKey(comamd[0]))
                {
                    products.Add(comamd[0], new List<double>() { price, quantity });
                }
                else
                {
                    double secqua = products[comamd[0]][1];
                    products[comamd[0]] = new List<double>() { price, secqua + quantity };
                }

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                double total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {total:f2}");
            }
        }
    }
}
