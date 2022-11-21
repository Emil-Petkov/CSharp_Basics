using System;

namespace depositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());


            double interestForTheEntirePeriod = (depositSum * interest) / 100;
            double interestForTheMonth = interestForTheEntirePeriod / 12;

            double totalSum = depositSum + months * interestForTheMonth;

            Console.WriteLine(totalSum);
        }
    }
}