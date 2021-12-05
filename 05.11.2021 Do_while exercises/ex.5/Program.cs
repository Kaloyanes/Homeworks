using System;

namespace ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine()) / 100;
            double desired = double.Parse(Console.ReadLine());
            int years = 0;

            do
            {
                amount += amount * interest;

                Console.WriteLine(amount);
                years++;
            } while (amount < desired);

            Console.WriteLine($"After year: {years}");
        }
    }
}
