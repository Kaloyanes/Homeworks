using System;

namespace ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Нарочно добавям -0.5 на input-а за да не се повтарят числата
            double input = Math.Abs(int.Parse(Console.ReadLine())) - 0.5;

            while (input >= 0)
            {
                Console.WriteLine(input);
                input -= 0.5;
            }
        }
    }
}
