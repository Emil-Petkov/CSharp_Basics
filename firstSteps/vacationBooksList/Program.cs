using System;

namespace vacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int allPagesInTheBook = int.Parse(Console.ReadLine());
            int readPagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int neededTimePerTheBook = allPagesInTheBook / readPagesPerHour;
            int neededTimePerDay = neededTimePerTheBook / days;

            Console.WriteLine(neededTimePerDay);

        }
    }
}