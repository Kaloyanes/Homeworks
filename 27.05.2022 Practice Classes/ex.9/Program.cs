namespace ex._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parking = new Parking();
            var rnd = new Random();

            var n = 15;
            for (int i = 0; i < n + 1; i++)
            {
                var parkPos = rnd.Next(0, n + 1);
                var isFree = parking.Park(parkPos);

                if (isFree)
                {
                    Console.WriteLine($"Car {i} parked at {parkPos}");
                }
                else
                {
                    Console.WriteLine($"Car {i} not parked");
                    i--;
                }
            }
        }
    }
}