using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> AnimalNfood = new Dictionary<string, int>();
            Dictionary<string,Dictionary<string,int>> animalNArea = new Dictionary<string,Dictionary<string,int>>();

            string input = Console.ReadLine();

            while (input !="EndDay")
            {
                string[] comand = input.Split(": ");
                string curentcomand = comand[0];
                string nameAnimal = comand[1];
                

                
                if (curentcomand=="Add")
                {
                    string[] second = nameAnimal.Split("-");
                    string animal = second[0];
                    int food = int.Parse(second[1]);
                    string area = second[2];
                    if (!AnimalNfood.ContainsKey(animal))
                    {
                        AnimalNfood.Add(animal, food);
                        animalNArea.Add(animal,new Dictionary<string, int>());
                        if (animalNArea[animal].ContainsKey(area)  )
                        {
                            animalNArea[animal][area] += 1;
                        }
                        else
                        {
                            animalNArea[animal].Add(area, 1);
                        }
                    }
                    else
                    {
                        AnimalNfood[animal] += food;
                    }
                }
                else if (curentcomand=="Feed")
                {
                    string[] second = nameAnimal.Split("-");
                    string anim = second[0];
                    int foo = int.Parse(second[1]);
                    if (AnimalNfood.ContainsKey(anim))
                    {
                        AnimalNfood[anim] -= foo;
                        if (AnimalNfood[anim] <= 0)
                        {
                            Console.WriteLine($"{anim} was successfully fed");
                            AnimalNfood.Remove(anim);
                            animalNArea.Remove(anim);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Animals:");
            foreach (var item in AnimalNfood.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                 Console.WriteLine($"{item.Key} -> {item.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            
            foreach (var item in animalNArea)
            {
                foreach (var sql in item.Value)
                {
                    Console.WriteLine($"{sql.Key}: {sql.Value}");
                }
            }
        }
    }
}
