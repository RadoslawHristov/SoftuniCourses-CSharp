using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroHP = new Dictionary<string, int>();
            Dictionary<string, int> heroMP = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string[] heroandhpmp = Console.ReadLine().Split();
                string hero = heroandhpmp[0];
                int hp = int.Parse(heroandhpmp[1]);
                int mp = int.Parse(heroandhpmp[2]);
                if (!heroHP.ContainsKey(hero))
                {
                    heroHP.Add(hero, hp);
                    heroMP.Add(hero, mp);
                }
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] comand = input.Split(" - ");
                if (comand[0] == "CastSpell")
                {
                    string heroname = comand[1];
                    int Mpneed = int.Parse(comand[2]);
                    string mana = comand[3];

                    if (heroMP[heroname] < Mpneed)
                    {
                        Console.WriteLine($"{heroname} does not have enough MP to cast {mana}!");
                    }
                    else
                    {
                        heroMP[heroname] -= Mpneed;
                        Console.WriteLine($"{heroname} has successfully cast {mana} and now has {heroMP[heroname]} MP!");
                    }
                }
                else if (comand[0] == "TakeDamage")
                {
                    string namesh = comand[1];
                    int demage = int.Parse(comand[2]);
                    string nameattack = comand[3];
                    heroHP[namesh] -= demage;
                    if (heroHP[namesh] > 0)
                    {
                        Console.WriteLine($"{namesh} was hit for {demage} HP by {nameattack} and now has {heroHP[namesh]} HP left!");
                    }
                    else
                    {
                        heroHP.Remove(namesh);
                        Console.WriteLine($"{namesh} has been killed by {nameattack}!");
                    }
                }
                else if (comand[0] == "Recharge")
                {
                    string name = comand[1];
                    int mana = int.Parse(comand[2]);

                    if (heroMP[name]+ mana > 200)
                    {
                        Console.WriteLine($"{name} recharged for {200 - heroMP[name]} MP!");
                        heroMP[name] = 200;
                    }
                    else
                    {
                        heroMP[name] += mana;
                        Console.WriteLine($"{name} recharged for {mana} MP!");
                    }
                   
                    
                }
                else if (comand[0] == "Heal")
                {
                    string names = comand[1];
                    int healt = int.Parse(comand[2]);

                    if (heroHP[names] + healt > 100)
                    {
                        Console.WriteLine($"{names} healed for {100-heroHP[names]} HP!");
                        heroHP[names] = 100;
                    }
                    else
                    {
                        heroHP[names] += healt;
                        Console.WriteLine($"{names} healed for {healt} HP!");
                    }
                   

                }
                input = Console.ReadLine();
            }

            foreach (var item in heroHP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                 Console.WriteLine($" HP: {item.Value}");
                 Console.WriteLine($" MP: {heroMP[item.Key]}");
            }
        }
    }
}
