using System;

namespace ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()), max = int.MinValue;

            while (input != 0)
            {
                if (input % 10 > max)
                    max = input;
                input /= 10;
            }

            Console.WriteLine(max);
        }
    }
}
