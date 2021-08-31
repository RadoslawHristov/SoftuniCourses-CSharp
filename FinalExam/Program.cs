using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] comand = input.Split();
                if (comand[0] == "Case")
                {
                    if (comand[1] == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if (comand[1] == "upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if (comand[0] == "Reverse")
                {
                    string emp = String.Empty;
                    int strarind = int.Parse(comand[1]);
                    int Endind = int.Parse(comand[2]);
                    if (strarind > 0 && Endind < username.Length)
                    {
                        emp = username.Substring(strarind, Endind-strarind+1);
                        string revers = string.Empty;
                        for (int i = emp.Length - 1; i >= 0; i--)
                        {
                            revers += emp[i];
                        }
                        Console.WriteLine(revers);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (comand[0] == "Cut")
                {
                    string task = comand[1];
                    if (username.Contains(task))
                    {
                        int indexstart = username.IndexOf(task[0]);
                        int endindex = username.IndexOf(task[task.Length - 1]);
                        username = username.Remove(indexstart, endindex - indexstart + 1);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word peter doesn't contain {task}.");
                    }
                }
                else if (comand[0] == "Replace")
                {
                    string letter = comand[1];
                    string sinbol = "*";
                    username = username.Replace(letter, sinbol);
                    Console.WriteLine(username);
                }
                else if (comand[0] == "Check")
                {
                    char simbol = char.Parse(comand[1]);
                    if (username.Contains(simbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {simbol}.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
