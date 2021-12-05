using System;

namespace ex._3
{
    internal class Program
    {
        static double CalculateHypotenusе(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = CalculateHypotenusе(a, b);

            Console.WriteLine($"{c:F2}");
        }
    }
}
