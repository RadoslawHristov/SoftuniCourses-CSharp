using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = new List<string>();

            string input = Console.ReadLine();

            while (input !="end")
            {
                string[] comand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (comand[0]== "Chat")
                {
                    message.Add(comand[1]);
                }
                else if (comand[0]=="Delete")
                {
                    if (message.Contains(comand[1]))
                    {
                        message.Remove(comand[1]);
                    }
                    
                }
                else if (comand[0]=="Edit")
                {
                    if (message.Contains(comand[1]))
                    {
                        int ind = message.IndexOf(comand[1]);
                        message.Insert(ind,comand[2]);
                        message.RemoveAt(ind+1);
                    }
                }
                else if (comand[0]=="Pin")
                {
                    if (message.Contains(comand[1]))
                    {
                        int ins = message.IndexOf(comand[1]);
                        message.RemoveAt(ins);
                        message.Add(comand[1]);
                    }
                }
                else if (comand[0]=="Spam")
                {
                    for (int i = 1; i <comand.Length ; i++)
                    {
                        message.Add(comand[i]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var mesages in message)
            {
                Console.WriteLine(mesages);
            }
            
        }
    }
}
