using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> atackplanet = new List<string>();
            List<string> destroyplanet = new List<string>();
            for (int i = 0; i <n ; i++)
            {
                string input = Console.ReadLine();
                string key = @"[STARstar]";
                int counter = Regex.Matches(input, key).Count;
                StringBuilder sb = new StringBuilder();
                foreach (char item in input)
                {
                    sb.Append((char)(item - counter));
                }
                string patern = @"\@([A-Za-z]+)[^@\-!:>]*:([0-9]+)[^@\-!:>]*!([A-Z])![^@\-!:>]*->([0-9]+)";
                Match matchh = Regex.Match(sb.ToString(), patern);
                if (!matchh.Success)
                {
                    continue;
                }
                string planet = matchh.Groups[1].Value;
                int population = int.Parse(matchh.Groups[2].Value);
                string attack = matchh.Groups[3].Value;
                int soldier = int.Parse(matchh.Groups[4].Value);
                if (attack=="A")
                {
                    atackplanet.Add(planet);
                }
                else if (attack=="D")
                {
                    destroyplanet.Add(planet);
                }
            }

            Console.WriteLine($"Attacked planets: {atackplanet.Count}");
            foreach (var item in atackplanet.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyplanet.Count}");
            foreach (var item in destroyplanet.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {item}"); 
            }
        }
    }
}
