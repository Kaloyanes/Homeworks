using System;

namespace ex._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "no";

            int input = int.Parse(Console.ReadLine()), previous = 0;

            while (input != 0)
            {
                if (previous == input % 10 && input % 10 == 0)
                {
                    msg = "yes";
                    break;
                }

                previous = input % 10;
                input /= 10;
            }

            Console.WriteLine(msg);
        }
    }
}
