using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sum = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                sum[i] = SumVowelandConstant(name);
            }
            Array.Sort(sum);
            foreach (var element in sum)
            {
                Console.WriteLine(element);
            }
        }

        static int SumVowelandConstant(string text)
        {
            int sum = 0;
            foreach (char element in text)
            {
                if (element == 'a' || element == 'A' || element == 'e' || element == 'E' ||
                    element == 'i' || element == 'I' || element == 'u' || element == 'U' || element == 'o' ||
                    element == 'O')
                {
                    sum += (int) element * text.Length;
                }
                else
                {
                    sum += (int) element / text.Length;
                }
            }
            return sum;
        }
    }
}
