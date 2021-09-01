using System;

namespace firsttask
{
    class Program
    {
        static void Main(string[] args)
        {
            int bisckuitforday = int.Parse(Console.ReadLine());
            int wolker = int.Parse(Console.ReadLine());
            int biscuitkon = int.Parse(Console.ReadLine());
            double sumbisckuit = 0;
            int count = 0;
            double forday = bisckuitforday * wolker;
            for (int i = 1; i <= 30; i++)
            {
                sumbisckuit += forday;
                count++;
                if (count % 3==0)
                {
                    sumbisckuit -= forday-(forday * 0.75);
                }
            }
            double result = Math.Abs(sumbisckuit-biscuitkon);
            double proceed = (result / biscuitkon * 100);
            
            if (sumbisckuit > biscuitkon)
            {
                Console.WriteLine($"You have produced {sumbisckuit} biscuits for the past month.");
                Console.WriteLine($"You produce {proceed:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You have produced {sumbisckuit} biscuits for the past month.");
                Console.WriteLine($"You produce {proceed:f2} percent less biscuits.");
            }
        }
    }
}
