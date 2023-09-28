using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt hoppade Elin?");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Och hur lång hoppade Alma");
            double tal2 = double.Parse(Console.ReadLine());

            double summa = (tal1 - tal2);
            Console.WriteLine("Elin hoppade " + summa + " Meter längre än Alma");
            Console.ReadKey();
        }
    }
}

