using System;

namespace ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
