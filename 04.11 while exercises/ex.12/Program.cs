using System;
using System.Collections.Generic;

namespace ex._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> digits = new List<int>() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            int input = int.Parse(Console.ReadLine());
            while (input != 0)
            {
                int digit = input % 10;
                if (digit == 0)
                    digits[0]++;
                else
                    digits[digit]++;

                input /= 10;
            }

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"{i} -> {digits[i]}");
            }
        }
    }
}
