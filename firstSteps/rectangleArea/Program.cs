using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sideA = int.Parse(Console.ReadLine());
           int sideB = int.Parse(Console.ReadLine());

            int recctangleArea = sideA * sideB;

            Console.WriteLine(recctangleArea);
        }
    }
}