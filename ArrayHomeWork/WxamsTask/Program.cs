using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<place>[A-Z][a-z]{2,})\1";

            string input = Console.ReadLine();
            MatchCollection match = Regex.Matches(input, pattern);
            
            string result=String.Join(", ",match.Select(x=>x.Groups["place"].Value));
            string places=String.Join("",match.Select(x=>x.Groups["place"].Value));

            Console.WriteLine($"Destinations: {result}");
            Console.WriteLine($"Travel Points: {places.Length}");
        }
    }
}
