using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var item in banned)
            {
                text = text.Replace(item, new string('*', item.Length));
            }

            Console.WriteLine(text);
        }
    }
}
