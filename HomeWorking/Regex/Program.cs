using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int health = 0;
            double damege = 0;
            for (int i = 0; i < input.Count; i++)
            {
                string letter = @"([A-Za-z])([^\-*\\\.[^0-9]])*";
                string demage = @"[^*A-Za-z\\/][0-9.]*";
                string multiplay = @"[*]+";
                string devide = @"[\\]+";
                MatchCollection mat = Regex.Matches(input[i], letter);
                MatchCollection matc = Regex.Matches(input[i], demage);
                Match multiplayc = Regex.Match(input[i], multiplay);
                Match devidedc = Regex.Match(input[i], devide);
                health = 0;

                foreach (Match item in mat)
                {
                    health += Convert.ToChar(item.Value);
                }

                damege = 0;
                foreach (Match item in matc)
                {
                    damege += Convert.ToDouble(item.Value);
                }
                if (multiplayc.Success || devidedc.Success)
                {
                    for (int j = 0; j < multiplayc.Length; j++)
                    {
                        damege *= multiplayc.Length;
                    }
                }


                for (int j = 0; j < input.Count; j++)
                {
                    Console.WriteLine($"{input[i]} - {health} health, {damege:f2} damage");
                }
            }
            
        }
    }
}
