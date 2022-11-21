using System;

namespace fishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lengthInCubicCentimeters = int.Parse(Console.ReadLine());
            int widthInCubicCentimeters = int.Parse(Console.ReadLine());
            int heightInCubicCentimeters = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double tankAreaInCubicCentimeters = lengthInCubicCentimeters * widthInCubicCentimeters * heightInCubicCentimeters;

            double tankInLiters = tankAreaInCubicCentimeters / 1000;

            double neededLiters = tankInLiters * (1 - (percent / 100));

            Console.WriteLine(neededLiters);

        }
    }
}