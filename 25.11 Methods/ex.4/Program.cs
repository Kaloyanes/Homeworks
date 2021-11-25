using System;

namespace ex._4
{
    internal class Program
    {
        static double CalculateTaxiFare(double basePrice, double kmPrice, double kilometers)
        {
            return basePrice + (kmPrice * kilometers);
        }

        static void Main(string[] args)
        {
            double basepr = double.Parse(Console.ReadLine());
            double kmprice = double.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculateTaxiFare(basepr, kmprice, km):F2}");
        }
    }
}
