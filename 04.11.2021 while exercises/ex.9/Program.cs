using System;

namespace ex._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "no";

            int input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                if (input % 10 == 0)
                {
                    msg = "yes";
                    break;
                }
                input /= 10;
            }

            Console.WriteLine(msg);
        }
    }
}
