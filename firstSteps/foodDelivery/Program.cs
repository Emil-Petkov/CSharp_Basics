using System;

namespace foodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countChikenMenue = int.Parse(Console.ReadLine());
            int countFishMenue = int.Parse(Console.ReadLine());
            int countVeganMenue = int.Parse(Console.ReadLine());

            double priceChikenMenue = 10.35;
            double priceFishMenue = 12.40;
            double priceVeganMenue = 8.15;

            double amountUpToHere = (countChikenMenue * priceChikenMenue) +
                (countFishMenue * priceFishMenue) +
                (countVeganMenue * priceVeganMenue);

            double desert = amountUpToHere * 0.20;

            double delivery = 2.50;

            double totalAmount = amountUpToHere + desert + delivery;


            Console.WriteLine(totalAmount);

        }
    }
}