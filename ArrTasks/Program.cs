using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args) {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotacion = int.Parse(Console.ReadLine());
            for (int j = 0; j <rotacion; j++)
            {
                int temp = number[0];
                
                for (int i = 0; i < number.Length-1; i++)
                {
                    number[i] = number[i + 1];
                }
                number[number.Length - 1] = temp;
            }
            
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
