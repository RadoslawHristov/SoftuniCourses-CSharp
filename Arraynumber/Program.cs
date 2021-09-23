using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bestsquens = 0;
            int best = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                int curentnum = sum[i];
                int squens = 1;
                
                for (int j =i+1; j < sum.Length; j++)
                {
                    int curt = sum[j];
                    if (curentnum==curt)
                    {
                        squens += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (squens > bestsquens)
                {
                    bestsquens = squens;
                    best = curentnum;
                }
            }

            for (int i = 0; i <bestsquens ; i++)
            {
                Console.Write($"{best} ");
            }
            
        }
    }
}
