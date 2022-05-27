namespace ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carsDict = new Dictionary<string, Car>();
            int carsNumber = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < carsNumber; i++)
            {
                string[] argsCar = Console.ReadLine().Trim().Split();

                string model = argsCar[0];
                double fuelAmount = double.Parse(argsCar[1]);
                double fuelConsumption = double.Parse(argsCar[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                carsDict.Add(model, car);
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Trim().Split();

                if (commands[0].ToLower() == "end")
                {
                    break;
                }

                string command = commands[0];
                switch (command)
                {
                    case "Drive":
                        var car = carsDict[commands[1]];
                        double distance = double.Parse(commands[2]);
                        
                        car.Drive(distance);
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

            foreach (var car in carsDict.Values)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}