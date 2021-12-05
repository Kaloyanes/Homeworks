using System;

namespace ex._5
{
    internal class Program
    {
        static double CalculateTaxiFare(double basePrice, double kmPrice, double kilometers, double minutePrice,
            int minutes)
        {
            return basePrice + (kmPrice * kilometers) + (minutePrice * minutes);
        }

        static void Main(string[] args)
        {
            double basepr = double.Parse(Console.ReadLine());
            double kmprice = double.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());
            double minuteprice = double.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculateTaxiFare(basepr, kmprice, km, minuteprice, min):F2}");
        }
    }
}
