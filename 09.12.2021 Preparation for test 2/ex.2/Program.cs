string Calculate(double budget, double priceFirst)
{
    double priceSecond = priceFirst * 0.2;
    double priceThird = priceSecond * 0.7;
    double priceFourth = priceSecond * 0.5;

    double price = priceFirst + priceSecond + priceThird + priceFourth;
    budget -= price;

    if (budget > 0)
        return $"Yes! {budget:F2} leva left";

    return $"No! {Math.Abs(budget):F2} leva needed";
}

{
    double budget = double.Parse(Console.ReadLine());
    double priceFirst = double.Parse(Console.ReadLine());

    Console.WriteLine(Calculate(budget, priceFirst));
}