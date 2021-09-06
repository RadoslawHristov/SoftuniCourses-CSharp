using System;
using System.Linq;

namespace _11._Array_ManipulatorMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string comand = inp[0];

                if (comand == "exchange")
                {
                    int action = int.Parse(inp[1]);
                    if (action > num.Length)
                    {
                        Console.WriteLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }
                    GetExchange(num, action);
                    
                }
                else if (comand == "max")
                {
                    string evenodd = inp[1];
                    int number = GetOddEven(evenodd);
                    int man = GetMax(num, number);
                    PrintMinMaxindex(man);
                }
                else if (comand == "min")
                {
                    string evenodd = inp[1];
                    int number = GetOddEven(evenodd);
                    int min = Getmin(num, number);
                    PrintMinMaxindex(min);
                }
                else if (comand == "first")
                {
                    int count = int.Parse(inp[1]);
                    int number = GetOddEven(inp[2]);
                    if (count > num.Length)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }

                    int[] firsnumbers = Getfirstnumber(num, number, count);
                    if (firsnumbers.Length == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", firsnumbers)}]");
                    }
                }
                else if (comand == "last")
                {
                    int count = int.Parse(inp[1]);
                    int number = GetOddEven(inp[2]);
                    if (count > num.Length)
                    {
                        Console.WriteLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }
                    int[] lastnum = Getlastnumber(num, number, count);
                    if (lastnum.Length == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else
                    {
                        Console.WriteLine($"[{string.Join(", ", lastnum)}]");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",num)}]");
        }

        static int[] Getlastnumber(int[] num, int number, int count)
        {
            int array = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (array == count)
                {
                    break;
                }

                if (num[i] % 2 == number)
                {
                    array++;
                }
            }

            int[] lastnumbers = new int[array];
            int counters = 0;
            for (int j = num.Length - 1; j >= 0; j--)
            {
                if (array == 0)
                {
                    break;
                }
                if (num[j] % 2 == number)
                {
                    lastnumbers[counters++] = num[j];
                    array--;
                }
            }
            return lastnumbers;
        }

        static int[] Getfirstnumber(int[] num, int number, int count)
        {
            int arrLeht = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (arrLeht == count)
                {
                    break;
                }
                if (num[i] % 2 == number)
                {
                    arrLeht++;
                }
            }

            int[] firstnum = new int[arrLeht];
            int counter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (arrLeht == 0)
                {
                    break;
                }
                if (num[i] % 2 == number)
                {
                    firstnum[counter++] = num[i];
                    arrLeht--;
                }
            }

            return firstnum;
        }

        private static void PrintMinMaxindex(int man)
        {
            if (man == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(man);
            }
        }

        static int Getmin(int[] num, int number)
        {
            int minindex = -1;
            int min = int.MaxValue;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] < min && num[i] % 2 == number)
                {
                    min = num[i];
                    minindex = i;
                }
            }
            return minindex;
        }

        static int GetOddEven(string evenodd)
        {
            if (evenodd == "odd")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int GetMax(int[] num, int OddEven)
        {
            int maxindex = -1;
            int max = int.MinValue;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] > max && num[i] % 2 == OddEven)
                {
                    max = num[i];
                    maxindex = i;
                }
            }

            return maxindex;
        }

        static void GetExchange(int[] num, int action)
        {
            int[] right = new int[num.Length - action - 1];
            int[] left = new int[action + 1];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = num[i];
            }

            int count = 0;

            for (int i = action + 1; i < num.Length; i++)
            {
                right[count++] = num[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                num[i] = right[i];
            }

            count = 0;
            for (int i = num.Length - action - 1; i < num.Length; i++)
            {
                num[i] = left[count++];
            }
        }
    }
}