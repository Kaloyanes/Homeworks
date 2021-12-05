using System;

namespace ex._9
{
    internal class Program
    {
        static string GetChineseZodiac(int year)
        {
            year %= 12;

            switch (year)
            {
                case 0:
                    return "Monkey";

                case 1:
                    return "Rooster";

                case 2:
                    return "Dog";

                case 3:
                    return "Pig";

                case 4:
                    return "Rat";

                case 5:
                    return "Ox";

                case 6:
                    return "Tiger";

                case 7:
                    return "Rabbit";

                case 8:
                    return "Dragon";

                case 9:
                    return "Snake";

                case 10:
                    return "Horse";

                case 11:
                    return "Sheep";

                default:
                    throw new ArgumentException("Invalid year");
            }
        }

        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(GetChineseZodiac(year));
        }
    }
}
