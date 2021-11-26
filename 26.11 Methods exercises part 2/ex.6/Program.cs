double Ratio(double CarLiquid)
{
    return CarLiquid * 3;
}

double CarLiquid = double.Parse(Console.ReadLine());

Console.WriteLine($"{Ratio(CarLiquid)}");