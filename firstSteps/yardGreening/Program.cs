using System;

namespace yardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double allAreaInSquareMeters = double.Parse(Console.ReadLine());
            double pricePerOneSquareMeter = 7.61;
            double neededMoneyBeforeDiscount = allAreaInSquareMeters * pricePerOneSquareMeter;

            double discount = neededMoneyBeforeDiscount * 0.18;

            double finalSum = neededMoneyBeforeDiscount - discount;


            Console.WriteLine($"The final price is: {finalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}