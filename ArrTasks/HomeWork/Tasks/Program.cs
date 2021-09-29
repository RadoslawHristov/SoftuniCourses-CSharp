using System;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string oderpas=String.Empty;
            while (true)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0]== "Done")
                {
                    break;
                }

                if (comand[0]== "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2==1)
                        {
                            oderpas += password[i];
                        }
                    }

                    password = oderpas;
                    Console.WriteLine(password);
                }
                else if (comand[0]== "Cut")
                {
                    int indexremove = int.Parse(comand[1]);
                    int removeleght = int.Parse(comand[2]);
                    password = password.Remove(indexremove, removeleght);
                    Console.WriteLine(password);
                }
                else if (comand[0]== "Substitute")
                {
                    string element = comand[1];
                    string replece = comand[2];

                    if (password.Contains(element))
                    {
                        password = password.Replace(element, replece);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
