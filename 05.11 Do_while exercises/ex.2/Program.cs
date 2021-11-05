using System;

namespace ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int copyOfN = n;
            Console.WriteLine(1);
            do
            {
                Console.WriteLine($"{n}");
                n *= copyOfN;
            } while (n <= b);
        }
    }
}
