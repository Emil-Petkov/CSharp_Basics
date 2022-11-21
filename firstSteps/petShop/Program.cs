using System;

namespace petShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int howManyFoodDogs = int.Parse(Console.ReadLine());
            int howManyFoodCats = int.Parse(Console.ReadLine());

            double priceFoodDogs = 2.50;
            double priceFoodCats = 4.00;


            double total = (howManyFoodDogs * priceFoodDogs) +
                (howManyFoodCats * priceFoodCats);


            Console.WriteLine($"{total} lv.");
        }
    }
}