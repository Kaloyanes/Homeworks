using System;
using System.Linq;

namespace ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = -1, counter = -1;

            while (n != 0)
            {
                counter++;
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(counter);
        }
    }
}
