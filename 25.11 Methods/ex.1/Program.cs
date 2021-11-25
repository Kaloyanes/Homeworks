using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Transactions;

namespace ex._1
{
    internal class Program
    {
        public static double MinutesToHours(int minutes)
        {
            return (double)minutes / 60;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{MinutesToHours(140):F2}");
        }
    }
}
