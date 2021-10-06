using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> UsPostPoint = new Dictionary<string, Dictionary<string, int>>();
            List<string> inp = new List<string>();
            List<string> pvsp = new List<string>();
            while (input !="Season end")
            {
                
                if (input.Contains("->"))
                {
                    inp = Regex.Split(input,"->").ToList();
                    string name = inp[0];
                    string position = inp[1];
                    int skillpoint = int.Parse(inp[2]);

                    if (!UsPostPoint.ContainsKey(name))
                    {
                        UsPostPoint.Add(name, new Dictionary<string, int>());
                    }

                    if (!UsPostPoint[name].ContainsKey(position))
                    {
                        UsPostPoint[name].Add(position, 0);
                    }

                    if (UsPostPoint[name][position] <= skillpoint)
                    {
                        UsPostPoint[name][position] = skillpoint;
                    }
                }
                else
                {
                    pvsp = Regex.Split(input, "vs").ToList();
                    string player1 =inp[0];
                    string player2 =inp[1];
                    if (!UsPostPoint.ContainsKey(player1) || !UsPostPoint.ContainsKey(player2))
                    {
                        continue;
                    }

                    bool isfaund = false;
                    foreach (var item in UsPostPoint[player1])
                    {
                        if (UsPostPoint[player2].ContainsKey(item.Key))
                        {
                            isfaund = true;
                        }
                    }

                    int totaplayer1 = 0;
                    int totalPlayer2 = 0;
                    if (isfaund)
                    { 
                        totaplayer1 = UsPostPoint[player1].Values.Sum();
                        totalPlayer2 =UsPostPoint[player2].Values.Sum();

                        if (totaplayer1 > totalPlayer2)
                        {
                            UsPostPoint.Remove(player2);
                        }
                        else if (totalPlayer2 > totaplayer1)
                        {
                            UsPostPoint.Remove(player1);
                        }

                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in UsPostPoint.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var men in item.Value.OrderByDescending(x => x.Value).ThenBy(c => c.Key))
                {
                    Console.WriteLine($"-{men.Key}<::> {men.Value}");
                }
            }

        }
    }
}
