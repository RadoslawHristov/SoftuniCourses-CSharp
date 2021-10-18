using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<=\s)([A-za-z0-9]+[-._]*[A-za-z0-9]+)@([A-Za-z]+(([-.]*)[A-Za-z]+)*\.[a-z]{2,})";
            MatchCollection maches = Regex.Matches(text, pattern);
            foreach (Match item in maches)
            {
                Console.WriteLine(item);
            }
        }
    }
}