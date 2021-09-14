using System;
using System.ComponentModel.Design;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstElement = char.Parse(Console.ReadLine());
            char secontElement = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i <input.Length; i++)
            {
                if (input[i]==firstElement || input[i]==secontElement)
                {
                    continue;
                }
                else if (firstElement >=input[i] && secontElement <=input[i]
                         || secontElement >= input[i] && firstElement <= input[i])
                {
                    sum += input[i];
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
