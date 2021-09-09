using System;
using System.Collections.Generic;

namespace Problem_2._Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comand = Console.ReadLine().Split("|");
            int health = 100;
            int bitcoin = 0;
            int count = 0;
            for (int i = 0; i <comand.Length; i++)
            {
                string[] input = comand[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                count++;
                string amaunt = input[0];
                int lowHealth = int.Parse(input[1]);

                if (amaunt == "potion")
                {
                    health += lowHealth;
                    if (health > 100)
                    {
                        lowHealth -= health - 100;
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {lowHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (amaunt == "chest")
                {
                    bitcoin += lowHealth;
                    Console.WriteLine($"You found {lowHealth} bitcoins.");
                }
                else
                {
                    health -= lowHealth;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {amaunt}.");
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {amaunt}.");
                        Console.WriteLine($"Best room: {count}");
                        break;
                    }
                }
            }

            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");
            }
            
        }
    }
}
