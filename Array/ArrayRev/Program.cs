using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] num = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 !=0)
                {
                    first[i] = num[0];
                    second[i] = num[1];
                }
                else
                {
                    first[i] = num[1];
                    second[i] = num[0];
                }

            }

            Console.WriteLine(string.Join(" ", second));
            Console.WriteLine(string.Join(" ", first));
        }
    }
}
