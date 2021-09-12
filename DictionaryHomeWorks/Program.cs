using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resorce = new Dictionary<string, int>();
            int count = 0;

            while (input != "stop")
            {
                int amunt = int.Parse(Console.ReadLine());
                if (resorce.ContainsKey(input))
                {
                    resorce[input] += amunt;
                }
                else
                {
                    resorce[input] = amunt;
                }
                input = Console.ReadLine();
            }

            foreach (var key in resorce.Keys)
            {
                Console.WriteLine($"{key} -> {resorce[key]}");
            }

        }
    }
}
