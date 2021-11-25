using System;

namespace ex._6
{
    internal class Program
    {
        static bool IsSameDigits(int number)
        {
            int temp = number % 10;
            int digit;
            bool same = true;

            while (number != 0)
            {
                digit = number % 10;

                if (digit != temp)
                    same = false;

                temp = digit;
                number /= 10;
            }

            return same;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (IsSameDigits(number))
                Console.WriteLine("yes");

            else
                Console.WriteLine("no");
        }
    }
}
