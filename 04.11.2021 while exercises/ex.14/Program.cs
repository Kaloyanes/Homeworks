using System;

namespace ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var rndNum = rnd.Next(1, 101);

            bool completed = false;

            // По-добре for ако имам конкретен брой животи
            for (int i = 0; i < 15; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == rndNum)
                {
                    completed = true;
                    Console.WriteLine("You win");
                    break;
                }

                else if(input < rndNum)
                    Console.WriteLine("The number is bigger.");
                
                else
                    Console.WriteLine("The number is smaller.");
            }

            if (!completed)
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"The number was {rndNum}");
            }

        }
    }
}
