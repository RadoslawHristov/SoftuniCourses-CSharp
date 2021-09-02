using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double pricegame = 0;
            double total = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Game Time")
                {
                    break;
                }

                if (input == "OutFall 4")
                {
                    pricegame = 39.99;
                }
                else if (input == "CS: OG")
                {
                    pricegame = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    pricegame = 19.99;
                }
                else if (input == "Honored 2")
                {
                    pricegame = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    pricegame = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    pricegame = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (pricegame > balance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                balance -= pricegame;
                Console.WriteLine($"Bought {input}");
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                total += pricegame;
            }

            Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${balance:f2}");
        }
    }
}
