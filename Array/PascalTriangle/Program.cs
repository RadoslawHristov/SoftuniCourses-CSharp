using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Reverse(number);
            foreach (var VARIABLE in number)
            {
                Console.Write(VARIABLE + " ");
            }
        }
    }
}
