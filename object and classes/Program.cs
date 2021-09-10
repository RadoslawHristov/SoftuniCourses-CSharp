using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Store_Boxes
{
    class Program
    {
        class Box
        {
            public Box()
            {
                
            }
            public string Serialnumber { get; set; }

            public string Item  { get; set; }

            public int Quantity { get; set; }

            public double Price { get; set; }

            public double total { get; set; }

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> finalPrice = new List<Box>();

            double totalPrice = 0;

            while (input != "end")
            {
                string[] Line = input.Split();

                string sernum = Line[0];
                string item = Line[1];
                int quant = int.Parse(Line[2]);
                double price =double.Parse( Line[3]);

                totalPrice = quant * price;

                Box box = new Box();
                {
                    box.Serialnumber = sernum;
                    box.Item = item;
                    box.Quantity = quant;
                    box.Price = price ;
                    box.total = quant * price;
                }
                finalPrice.Add(box);

                input = Console.ReadLine();
            }

            List<Box> sortedBox = finalPrice.OrderBy(boxes => boxes.total).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine($" {box.Serialnumber}");
                Console.WriteLine($"-- {box.Item} -" + 
                                  $" ${box.Price:f2}:" +
                                  $" {box.Quantity}");

                Console.WriteLine($"-- ${box.total:f2}");
            }
        }
    }
}
