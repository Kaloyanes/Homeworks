using System;
using System.Collections.Generic;

namespace _18._10_additional_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Phoenix count 
            int n = int.Parse(Console.ReadLine());

            // Making a list to contain all years
            List<double> totalYearsForPhoenixes = new List<double>();
            for (int i = 0; i < n; i++)
            {
                // Getting input
                int bodyLenght = int.Parse(Console.ReadLine());
                double bodyWidth = double.Parse(Console.ReadLine());
                int wingLenght = int.Parse(Console.ReadLine());

                // Creating a class phoenix that contains all the info for the bird
                var phoenix = new Phoenix(bodyLenght, bodyWidth, wingLenght);

                // Adding the year to the list of years
                totalYearsForPhoenixes.Add(phoenix.totalYears());
            }

            Console.WriteLine();

            // Iterating through every phoenix and showing the year to the user
            foreach (var year in totalYearsForPhoenixes)
            {
                Console.WriteLine(year);
            }
        }
    }
}
