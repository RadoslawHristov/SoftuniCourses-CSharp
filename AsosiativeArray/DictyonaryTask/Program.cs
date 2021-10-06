using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordandSin = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonym = Console.ReadLine();

                if (wordandSin.ContainsKey(word)==false)
                {
                    wordandSin.Add(word,new List<string>());
                    wordandSin[word].Add(sinonym);
                }
                else
                {
                    wordandSin[word].Add(sinonym);
                }
            }

            foreach (var item in wordandSin)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
