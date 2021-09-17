using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace _03_Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "find")
            {
                List<char> charInput = input.ToList();
                int keyL = 0;
                for (int i = 0; i < charInput.Count; i++)
                {
                    charInput[i] = Convert.ToChar(charInput[i] - key[keyL]);
                    keyL++;
                    if (keyL == key.Length)
                    {
                        keyL = 0;
                    }

                }
                string pattern = @".*([&])(?'tr'[a-zA-Z]*)([&]).*([<])(?'coo'.*)([>])";
                char[] str = charInput.ToArray();
                string nnew = new string(str);
                Regex reg = new Regex(pattern);
                Match mat = reg.Match(nnew);
                if (mat.Success)
                {
                    Console.WriteLine($"Found {mat.Groups["tr"]} at {mat.Groups["coo"]}");
                }
                input = Console.ReadLine();
            }

        }
    }
}

