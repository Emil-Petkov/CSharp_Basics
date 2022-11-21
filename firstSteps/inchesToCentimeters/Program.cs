using System;

namespace inchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cm = inches * 2.54;

            double result = cm;

            Console.WriteLine(cm);
        }
    }
}