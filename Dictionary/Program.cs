using System;
using System.Text.RegularExpressions;

namespace Problem222
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string username = @"[U$]{1,}([A-Z]{1}[a-z]{4,})[U$]{1,}[P@$]{1,}([a-z]{5,}[0-9]{1,})[P@$]{1,}";
           
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection match = Regex.Matches(input, username);
                if (match.Count > 0)
                {
                   
                    count++;
                    Console.WriteLine("Registration was successful");
                    foreach (Match item in match)
                    {
                        string users = item.Groups[1].Value;
                        string password = item.Groups[2].Value;
                        Console.WriteLine($"Username: {users}, Password: {password}");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
        }
    }
}
