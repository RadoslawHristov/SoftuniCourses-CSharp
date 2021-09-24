using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> nameColorDeamage =
                new Dictionary<string, Dictionary<string, List<int>>>();


            while (count-- > 0)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                int demage =input[2]== "null" ? 45 : int.Parse(input[2]);
                int heath =input[3]== "null" ? 45 : int.Parse(input[3]);
                int armor =input[4]== "null" ? 45 : int.Parse(input[4]);

                if (!nameColorDeamage.ContainsKey(type))
                {
                    nameColorDeamage.Add(type,new Dictionary<string, List<int>>());
                }
                nameColorDeamage[type][name]=new List<int>();

                nameColorDeamage[type][name].Add(demage);
                nameColorDeamage[type][name].Add(heath);
                nameColorDeamage[type][name].Add(armor);
            }

            foreach (var item in nameColorDeamage)
            {
                double avDamage = 1.00 * (item.Value.Values.Select(x => x[0]).Sum()) / nameColorDeamage[item.Key].Count;
                double avHealth = 1.00 * (item.Value.Values.Select(x => x[1]).Sum()) / nameColorDeamage[item.Key].Count;
                double avArmor = 1.00 * (item.Value.Values.Select(x => x[2]).Sum()) / nameColorDeamage[item.Key].Count;

                Console.WriteLine($"{item.Key}::({avDamage:F2}/{avHealth:F2}/{avArmor:F2})");


                foreach (var dragon in item.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }

            }
        }
    }
}
