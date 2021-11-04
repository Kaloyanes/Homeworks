using System;
using System.Numerics;

namespace ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bigint = new BigInteger();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // Онзи ден открих този метод и затова него използвам. Знам, че мога да използвам Euclidian Algorithm
            var result = BigInteger.GreatestCommonDivisor(a, b);

            Console.WriteLine(result);
        }
    }
}
