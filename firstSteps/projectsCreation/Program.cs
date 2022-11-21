using System;

namespace projectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberProjects = int.Parse(Console.ReadLine());


            int neededHours = numberProjects * 3;

            Console.WriteLine($"The architect {name} will need {neededHours}" +
                $" hours to complete {numberProjects} project/s.");
        }
    }
}