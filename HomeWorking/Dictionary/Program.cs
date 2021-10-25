using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> element = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"motes", 0},
                {"fragments", 0}
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool isend = true;
            while (isend)
            {
                string[] input = Console.ReadLine().Split();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int vaalue = int.Parse(input[i]);
                    string elementss = input[i + 1].ToLower();
                    if (elementss == "shards")
                    {
                        element["shards"] += vaalue;
                    }
                    else if (elementss == "fragments")
                    {
                        element["fragments"] += vaalue;
                    }
                    else if (elementss == "motes")
                    {
                        element["motes"] += vaalue;
                    }
                    else
                    {
                        if (!junk.ContainsKey(elementss))
                        {
                            junk.Add(elementss, 0);
                        }

                        junk[elementss] += vaalue;
                    }
                    if (element.Any(x => x.Value >= 250))
                    {
                        isend = false;
                        break;
                    }
                }
            }
            if (element["motes"] >= 250)
            {
                element["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (element["shards"] >= 250)
            {
                element["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (element["fragments"] >= 250)
            {
                element["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }

            foreach (var item in element.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}