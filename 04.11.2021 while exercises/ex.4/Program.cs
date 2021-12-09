using System;

namespace ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string reversedNumber = "";
            while (n != 0)
            {
                reversedNumber += n % 10;
                n /= 10;
            }

            int reverseNum = int.Parse(Console.ReadLine());


            Console.WriteLine(reverseNum);
        }
    }
}
