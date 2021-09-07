using System;
using System.ComponentModel.Design;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            if (first < 0 || second < 0 || three <0)
            {
                Console.WriteLine("negative");
            }
            else if(first > 0 && second > 0 && three >0)
            {
                Console.WriteLine("positive");
            }
            else if (first==0 || second==0 || three==0)
            {
                Console.WriteLine("zero");
            }
            
        }
    }
}
