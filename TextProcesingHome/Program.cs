using System;
using System.Text;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int firstindex = input.LastIndexOf('@');
                int lastindname = input.LastIndexOf('|');
                string name = input.Substring(firstindex + 1, lastindname-1-firstindex);
                int ageFirstind = input.LastIndexOf('#');
                int agelastind = input.LastIndexOf('*');
                string age = input.Substring(ageFirstind + 1, agelastind - 1 - ageFirstind);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
