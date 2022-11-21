using System;

namespace usdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usdDolar = double.Parse(Console.ReadLine());

            double levaExchangeRate = 1.79549;

            double bgnLev = usdDolar * levaExchangeRate;

            Console.WriteLine(bgnLev);
        }
    }
}