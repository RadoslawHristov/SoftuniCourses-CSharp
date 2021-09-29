using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputtext = Console.ReadLine();

            string comand = Console.ReadLine();


            while (comand != "Travel")
            {
                string[] splited = comand.Split(":");

                if (splited[0]== "Add Stop")
                {
                    int index = int.Parse(splited[1]);
                    string text = splited[2];
                    if (index >= 0 && index < inputtext.Length)
                    {
                        inputtext=inputtext.Insert(index, text);
                    }

                    Console.WriteLine(inputtext);
                }
                else if (splited[0] == "Remove Stop")
                {
                    int stratind = int.Parse(splited[1]);
                    int endind = int.Parse(splited[2]);
                    if (stratind >=0 && endind < inputtext.Length)
                    {
                        inputtext = inputtext.Remove(stratind, endind - stratind + 1);
                    }
                    Console.WriteLine(inputtext);
                }
                else if (splited[0]== "Switch")
                {
                    string old = splited[1];
                    string newstr = splited[2];
                    inputtext = inputtext.Replace(old, newstr);
                    Console.WriteLine(inputtext);
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {inputtext}");
        }
    }
}
