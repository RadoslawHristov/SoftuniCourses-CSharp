using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
               
            Dictionary<char, int> indexes = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] !=' ' && !indexes.ContainsKey(input[i]))
                {
                    indexes.Add(input[i],1);
                    continue;
                }

                if (input[i] != ' ')
                {
                    indexes[input[i]]++;
                }
            }

            foreach (var item in indexes)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
