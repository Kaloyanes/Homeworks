double Calculate(double priceLaminate, double Width, double Lenght, double pricePad)
{
    double area = Width * Lenght;
    double laminate = area * priceLaminate;
    double pad = area * pricePad;

    double price = laminate + pad;

    price = price + (price * 0.4);

    return price;
}

{
    double priceLaminate = double.Parse(Console.ReadLine());

    double Width = double.Parse(Console.ReadLine());
    double Lenght = double.Parse(Console.ReadLine());

    double pricePad = double.Parse(Console.ReadLine());

    Console.WriteLine($"{Calculate(priceLaminate, Width, Lenght, pricePad):F2}");
}