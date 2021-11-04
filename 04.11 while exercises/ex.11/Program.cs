using System;

namespace ex._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "no";

            int input = int.Parse(Console.ReadLine()), previous = 0;

            while (input != 0)
            {
                int digit = input % 10;
                if (previous % 2 == 0 && digit % 2 == 0)
                {
                    msg = "yes";
                    break;
                }

                previous = digit;
                input /= 10;
            }

            Console.WriteLine(msg);
        }
    }
}
