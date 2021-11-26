double Calculate(double lenght, double width, double height, double pricePerM2)
{
    height *= 4;
    lenght *= 2;
    width *= 2;

    double ceiling = width * lenght;
    double lenghtWallsPrice = (lenght * pricePerM2 + height * pricePerM2) * 2;
    double widthWallsPrice = (width * pricePerM2 + height * pricePerM2) * 2;
    double ceilingPrice = ceiling * pricePerM2;

    return lenghtWallsPrice + widthWallsPrice + ceilingPrice;
}

double pricePerM2 = double.Parse(Console.ReadLine());

double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

Console.WriteLine(Calculate(lenght, width, height, pricePerM2));