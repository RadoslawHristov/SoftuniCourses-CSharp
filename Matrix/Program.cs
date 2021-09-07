using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);

        }

        static void PrintMatrix(int i)
        {
            for (int j = 0; j < i ; j++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine();
            }
            
            

           
        }
    }
}
