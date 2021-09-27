using System;
using System.Collections.Generic;
using System.Linq;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coockis = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input != "No More Money")
            {
                string[] comand = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (comand[0]== "OutOfStock")
                {
                    if (coockis.Contains(comand[1]))
                    {
                        coockis.RemoveAll(x => x == comand[1]);
                        
                      

                        //for (int i = 0; i < coockis.Count; i++)
                        //{
                        //    for (int j = i; j < coockis.Count-1; j++)
                        //    {
                        //        int inx = coockis.IndexOf(comand[1]);
                        //        coockis.RemoveAt(inx);
                        //    }
                        //} 
                    }
                }
                else if (comand[0]== "Required")
                {
                    int ind = int.Parse(comand[2]);
                    if (ind < coockis.Count && ind >=0)
                    {
                        coockis.Insert(ind, comand[1]);
                        coockis.RemoveAt(ind+1);
                    }
                }
                else if (comand[0]== "Last")
                {
                    coockis.Add(comand[1]);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",coockis));
        }
    }
}
