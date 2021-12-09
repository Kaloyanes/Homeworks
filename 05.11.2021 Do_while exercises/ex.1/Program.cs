using System;

namespace ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Please enter a positive number");

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Number entered: {n}");
        }
    }
}
