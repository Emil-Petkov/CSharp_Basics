using System;

namespace basketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int yearTax = int.Parse(Console.ReadLine());


            double shoes = yearTax  - (yearTax * 0.40);
            double suit = shoes - (shoes * 0.20);
            double ball = suit / 4;
            double accessories = ball / 5;


            double total = yearTax + shoes + suit + ball + accessories;

            Console.WriteLine(total);

        }
    }
}