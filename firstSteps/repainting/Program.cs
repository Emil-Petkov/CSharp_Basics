using System;

namespace repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int neededNylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());


            double pricePerNylon = 1.50;
            double pricePerPaint = 14.50;
            double pricePerPaintThinner = 5.00;


            double materials = ((neededNylon + 2) * pricePerNylon) +
                ((neededPaint * 1.10) * pricePerPaint) + (paintThinner * pricePerPaintThinner)
                + 0.40;

            double masterWagesPerHour = (materials * 0.30) * hours;


            double total = materials + masterWagesPerHour;

            Console.WriteLine(total);

        }
    }
}