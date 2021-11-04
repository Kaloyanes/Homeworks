using System;

namespace ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int input = 0;
            while (input != -1)
            {
                sum += input;
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
