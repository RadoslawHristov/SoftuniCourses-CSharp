using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> nameColfis = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Once upon a time")
            {
                string[] comand = input.Split("<:>", StringSplitOptions.RemoveEmptyEntries);
                string names = comand[0];
                string color = comand[1];
                int fisics = int.Parse(comand[2]);

                if (!nameColfis.ContainsKey(names))
                {
                    nameColfis.Add(names,new Dictionary<string, int>());
                    nameColfis[names].Add(color,fisics);
                }
                else
                {
                    if (nameColfis[names][color] < fisics)
                    {
                        nameColfis[names][color] = fisics;
                    }
                }

                if (nameColfis.ContainsKey(names))
                {
                    if (!nameColfis[names].ContainsKey(color))
                    {
                        nameColfis.Add(names,new Dictionary<string, int>());
                        nameColfis[names].Add(color,fisics);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in nameColfis.OrderByDescending(x=>x.Value)
                .ThenByDescending(x =>nameColfis.Where(y=>y.Key.Split(':')[1]== x.Key.Split(':')[1]).Count()))
            {
                Console.WriteLine("({0}) {1} <-> {2}",
                    item.Key.Split(':')[1],
                    item.Key.Split(':')[0],
                    item.Value);
            }
        }
    }
}
