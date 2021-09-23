using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (array1.Length==1)
            {
                Console.WriteLine(array1[0]);
                return;
            }
            int[] condensed = new int[array1.Length-1];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < condensed.Length-i ;j++)
                {
                    condensed[j] = array1[j] + array1[j + 1];
                }
                
                array1 = condensed;
            }

            Console.WriteLine(array1[0]);
        }
    }
}
