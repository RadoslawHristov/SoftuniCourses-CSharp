using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> program = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string comand = Console.ReadLine();
            while (comand != "course start")
            {
                string[] inputcomand = comand.Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (inputcomand[0] == "Add")
                {
                    if (program.Contains(inputcomand[1]))
                    {
                        continue;
                    }
                    else
                    {
                        program.Add(inputcomand[1]);
                    }
                }
                else if (inputcomand[0] == "Insert")
                {
                    string text = inputcomand[1];
                    int indexin = int.Parse(inputcomand[2]);
                    if (indexin < 0 || indexin >= program.Count || program.Contains(inputcomand[1]))
                    {
                        comand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        program.Insert(indexin, text);
                    }
                }
                else if (inputcomand[0] == "Remove")
                {
                    if (program.Contains(inputcomand[1]))
                    {
                        program.Remove(inputcomand[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (inputcomand[0] == "Swap")
                {
                    if (program.Contains(inputcomand[1]) && program.Contains(inputcomand[2]))
                    {
                        string curent1 = String.Empty;
                        string curent2 = String.Empty;
                        int index1 = 0;
                        int index2 = 0;
                        for (int i = 0; i < program.Count; i++)
                        {
                            if (program[i] == inputcomand[1])
                            {
                                curent1 = program[i];
                                index1 = i;
                                break;
                            }
                        }
                        for (int j = 0; j < program.Count; j++)
                        {
                            if (program[j] == inputcomand[2])
                            {
                                curent2 = program[j];
                                index2 = j;
                                break;
                            }
                        }
                        program.Insert(index1,curent2);
                        program.RemoveAt(index1+1);
                        if (program.Contains(curent2 + "-Exercise"))
                        {
                            int indexcur2 = program.IndexOf(curent2 + "-Exercise");
                            program.Insert(index1+1, curent2 + "-Exercise");
                            program.RemoveAt(indexcur2);

                        }

                        if (curent2==curent2 + "-Exercise")
                        {
                            program.Insert(index2 + 1, curent1);
                        }
                        else
                        {
                            program.Insert(index2, curent1);
                            program.RemoveAt(index2 + 1);
                        }
                        if (program.Contains(curent1 + "-Exercise"))
                        {
                            int indexcur1=program.IndexOf(curent1 + "-Exercise");
                            program.Insert(index2+1,curent1+ "-Exercise");
                            program.RemoveAt(indexcur1);
                        }
                    }
                }
                else if (inputcomand[0] == "Exercise")
                {
                    if (program.Contains(inputcomand[1]))
                    {
                        string curent = "-Exercise";

                        for (int i = 0; i < program.Count; i++)
                        {
                            if (program[i] == inputcomand[1])
                            {
                                program.Insert(i - 1, inputcomand[1]);
                                program.Insert(i, program[i] + curent);
                                break;
                            }
                        }
                    }
                    else
                    {
                        string curent = "-Exercise";
                        program.Add(inputcomand[1]);
                        program.Add(inputcomand[1] + curent);
                    }
                }
                
                comand = Console.ReadLine();
            }
            for (int i = 0; i < program.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{program[i]}");
            }
        }
    }
}