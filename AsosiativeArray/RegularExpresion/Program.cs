using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();
            var sb = new StringBuilder();
            var uniqueSymbols = new HashSet<char>();
            var result = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                var curChar = input[i];
                if (!char.IsNumber(input[i]))
                {
                    uniqueSymbols.Add(input[i]);
                    sb.Append(input[i]);
                }
                else
                {
                    var num = 0;
                    if (i.Equals(input.Length - 1))
                    {
                        num = int.Parse(input[i].ToString());
                    }
                    else
                    {
                        if (!char.IsNumber(input[i + 1]))
                        {
                            num = int.Parse(input[i].ToString());
                        }
                        else
                        {
                            num = int.Parse(input[i] + input[i + 1].ToString());
                            i += 1;
                        }
                    }
                    for (int j = 0; j < num; j++)
                    {
                        result.Add(sb.ToString());
                    }
                    sb.Clear();
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            var printResult = string.Join("", result);
            Console.WriteLine(printResult);
        }

    }
}