using System;
using System.Reflection;

namespace ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int validNums = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                while (input != 0)
                {
                    counter++;
                    input /= 10;
                }

                if(counter == k)
                    validNums++;

                counter = 0;
            }

            Console.WriteLine(validNums);
        }
    }
}
