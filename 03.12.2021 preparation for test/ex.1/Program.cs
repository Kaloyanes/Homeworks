{
    double pricePerLiter = double.Parse(Console.ReadLine());
    double champagneLiter = double.Parse(Console.ReadLine());
    double waterLiter = double.Parse(Console.ReadLine());
    double whiskeyLiter = double.Parse(Console.ReadLine());

    Console.WriteLine($"{Sum(pricePerLiter, champagneLiter, waterLiter, whiskeyLiter):F2}");
}

double Sum(double pricePerLiter, double champagneLiter, double waterLiter, double whiskeyLiter)
{
    double champagnePrice = champagneLiter * pricePerLiter;
    double waterPrice = waterLiter * (pricePerLiter / 4);
    double whiskeyPrice = whiskeyLiter * (pricePerLiter * 2.3);

    return champagnePrice + waterPrice + whiskeyPrice;
}