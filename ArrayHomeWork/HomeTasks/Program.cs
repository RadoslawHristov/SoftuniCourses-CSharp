using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int carscount = int.Parse(Console.ReadLine());
            Dictionary<string, int> ModelKM = new Dictionary<string, int>();
            Dictionary<string, int> ModelFuel = new Dictionary<string, int>();

            for (int i = 0; i <carscount; i++)
            {
                string[] splited = Console.ReadLine().Split("|");
                string model = splited[0];
                int kilometers = int.Parse(splited[1]);
                int Fuel = int.Parse(splited[2]);

                ModelKM.Add(model,kilometers);
                ModelFuel.Add(model,Fuel);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] comand = input.Split(" : ");
                if (comand[0]== "Drive")
                {
                    string models = comand[1];
                    int kilometer = int.Parse(comand[2]);
                    int fuel = int.Parse(comand[3]);
                    if (ModelFuel[models] > fuel)
                    {
                        ModelKM[models] += kilometer;
                        ModelFuel[models] -= fuel;
                        Console.WriteLine($"{models} driven for {kilometer} kilometers. {fuel} liters of fuel consumed.");
                        if (ModelKM[models] >= 100000)
                        {
                            ModelKM.Remove(models);
                            ModelFuel.Remove(models);
                            Console.WriteLine($"Time to sell the {models}!");
                            input = Console.ReadLine();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (comand[0]== "Refuel")
                {
                    string models = comand[1];
                    int fuel = int.Parse(comand[2]);

                    if (ModelFuel[models] + fuel > 75)
                    {
                        Console.WriteLine($"{models} refueled with {75-ModelFuel[models]} liters");
                        ModelFuel[models] = 75;
                    }
                    else
                    {
                        ModelFuel[models] += fuel;
                        Console.WriteLine($"{models} refueled with {fuel} liters");
                    }
                }
                else if (comand[0]== "Revert")
                {
                    string model = comand[1];
                    int kilometer = int.Parse(comand[2]);

                    ModelKM[model] -= kilometer;
                    if (ModelKM[model] < 10000)
                    {
                        ModelKM[model] = 10000;
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{model} mileage decreased by {kilometer} kilometers");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in ModelKM.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value} kms, Fuel in the tank: {ModelFuel[item.Key]} lt.");
            }
        }
    }
}
