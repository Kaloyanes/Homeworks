using System;

namespace ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, input = 0, counter = -1;

            while (input != -1)
            {
                counter++;
                sum += input;

                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{(double)sum / counter:F2}");
        }
    }
}
