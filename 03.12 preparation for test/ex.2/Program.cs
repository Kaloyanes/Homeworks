{
    double priceParty = double.Parse(Console.ReadLine());
    double nail = int.Parse(Console.ReadLine()) * 0.6;
    double nuts = int.Parse(Console.ReadLine()) * 7.2;
    double screws = int.Parse(Console.ReadLine()) * 3.6;
    double hammers = int.Parse(Console.ReadLine()) * 18.2;
    double wrenches = int.Parse(Console.ReadLine()) * 14;

    Console.WriteLine(Budget(priceParty, nail, nuts, screws, hammers, wrenches));
}

string Budget(double priceParty, double nail, double nuts, double screws, double hammers, double wrenches)
{
    double sum = nail + nuts + screws + hammers + wrenches;

    sum -= (sum * 0.1);

    if (sum > priceParty)
        return $"Yes! {Math.Ceiling(sum - priceParty)} lv left.";

    return $"No! {Math.Ceiling(Math.Abs(priceParty - sum))} lv needed.";
}