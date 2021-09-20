using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> Lenp = new List<int>();

            //List<int>longsequens=new List<int>(Lenp.Count);
            if (input.Length==1)
            {
                Console.WriteLine(1);
                return;
            }

            for (int i = 0; i < input.Length-1 ; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j] || input[i]+2==input[j])
                    {
                        Lenp.Add(input[i]);
                    }
                }
            }


            Console.WriteLine(string.Join(" ",Lenp));
        }    
    }
}
