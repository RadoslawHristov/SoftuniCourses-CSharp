using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if (item.Length < 3 || item.Length > 16)
                {
                    continue;
                }

                bool isvalid = false;

                foreach (var ist in item)
                {
                    if (!(char.IsLetter(ist) || char.IsDigit(ist) || ist=='_' || ist=='-'))
                    {
                        isvalid = false;
                        break;
                    }

                    isvalid = true;
                }

                if (isvalid)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
