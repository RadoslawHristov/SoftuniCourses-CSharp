using System;
using System.Linq;
using System.Net.Sockets;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int[] recing = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] left = new int[recing.Length / 2];
            int[] right = new int[recing.Length-1 - left.Length];

           
            double sumleft = 0;
            double sumright = 0;
            for (int i = 0; 
                i < left.Length; i++)
            {
                left[i] = recing[i];
                sumleft += left[i];
                if (left[i]== 0)
                {
                    sumleft = sumleft - sumleft * 0.2;
                }
            }
            for (int i= right.Length-1; i >= 0; i-- )
            {
                right[i] = recing[left.Length + 1+i];
                sumright += right[i];
                if (right[i]== 0)
                {
                    sumright = sumright - sumright * 0.2;
                }
            }

            if (sumright < sumleft)
            {
                Console.WriteLine($"The winner is right with total time: {sumright}");
            }
            else
            {
                Console.WriteLine($"The winner is left with total time: {sumleft}");
            }
            //Console.WriteLine(sumleft);
            //Console.WriteLine(sumright);
            //Console.WriteLine(string.Join(" ", left));
            //Console.WriteLine(string.Join(" ", right));
        }
    }
}
