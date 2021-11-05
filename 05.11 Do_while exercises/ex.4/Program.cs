using System;

namespace ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiveCounter = 0, negativeCounter = 0;

            while (positiveCounter != 5)
            {
                int n = int.Parse(Console.ReadLine());

                if (n > 0)
                    positiveCounter++;
                else
                    negativeCounter++;

            }

            Console.WriteLine(negativeCounter);
        }
    }
}
