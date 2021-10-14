using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0] == "End")
                {
                    break;
                }

                else if (comand[0] == "Add")
                {
                    int num = int.Parse(comand[1]);
                    number.Add(num);
                }
                else if (comand[0] == "Insert")
                {
                    int num = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    if (index < 0 || index >=number.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    number.Insert(index, num);
                }
                else if (comand[0] == "Remove")
                {
                    int n = int.Parse(comand[1]);
                    if (n < 0 || n >= number.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    number.RemoveAt(n);
                }
                else if (comand[1] == "left")
                {
                    int rotatte = int.Parse(comand[2]);

                    for (int i = 0; i < rotatte; i++)
                    {
                        int firstelement = number[0];

                        for (int j = 0; j < number.Count - 1; j++)
                        {
                            number[j] = number[j + 1];
                        }

                        number[number.Count - 1] = firstelement;
                    }
                }
                else if (comand[1] == "right")
                {
                    int n = int.Parse(comand[2]);

                    for (int i = 0; i < n; i++)
                    {
                        int lastelement = number[number.Count - 1];
                        number.RemoveAt(number.Count - 1);
                        number.Insert(0, lastelement);
                    }

                }

            }
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
