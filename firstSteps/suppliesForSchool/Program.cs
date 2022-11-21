using System;

namespace suppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numberOfPackOfPens = double.Parse(Console.ReadLine());
            double numberOfPackOfMarkers = double.Parse(Console.ReadLine());
            double boardPreparationInLiters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceForPackagePens = 5.80;
            double priceForPackageMarkers = 7.20;
            double pricePreparationPerLiter = 1.20;


            double sumBeforeDiscount = (numberOfPackOfPens * priceForPackagePens) 
                + (numberOfPackOfMarkers * priceForPackageMarkers) 
                + (boardPreparationInLiters * pricePreparationPerLiter);

            double finalSum = sumBeforeDiscount - (sumBeforeDiscount * (discount / 100));


            Console.WriteLine(finalSum);

        }
    }
}