using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Shopinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> product = Console.ReadLine()
                .Split('!',StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] comand = input.Split();

                if (comand[0]== "Urgent")
                {
                    if (product.Contains(comand[1]))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                            product.Insert(0,comand[1]);
                    }
                }
                else if (comand[0]== "Unnecessary")
                {
                    if (product.Contains(comand[1]))
                    {
                        product.Remove(comand[1]);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (comand[0]== "Correct")
                {
                    if (product.Contains(comand[1]))
                    {
                        int ind = product.IndexOf(comand[1]);
                        product.Insert(ind, comand[2]);
                        product.RemoveAt(ind+1);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (comand[0]== "Rearrange")
                {
                    if (product.Contains(comand[0]))
                    {
                        int indeks = product.IndexOf(comand[1]);
                        product.RemoveAt(indeks);
                        product.Add(comand[1]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",product));
        }
    }
}
