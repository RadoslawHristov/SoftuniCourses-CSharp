using System;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patdigit = @"([0-9])";
            string patern = @"([:*])\1([A-Z][a-z]{2,})\1{2}";
            string input = Console.ReadLine();

            MatchCollection matchdigit = Regex.Matches(input, patdigit);
            long coolEmodji = 1;

            for (int i = 0; i < matchdigit.Count; i++)
            {
                coolEmodji *= int.Parse(matchdigit[i].Value);
            }

            Console.WriteLine($"Cool threshold: {coolEmodji}");
            MatchCollection matchemodji = Regex.Matches(input, patern);
            Console.WriteLine($"{matchemodji.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in matchemodji)
            {
                int coolemodji = 0;
                string emodji = item.Groups[2].Value;
                for (int i = 0; i <emodji.Length ; i++)
                {
                    coolemodji +=emodji[i];
                }

                if (coolemodji >=coolEmodji)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
