double Calculate(double lenght, double width, double height, double pricePerM2)
{
    double ceilingArea = lenght * width;
    

    double ceilingPrice = ceilingArea * pricePerM2;
    double lenghtWallsPrice =  2 * ((lenght * height) * pricePerM2);
    double widthWallsPrice = 2 * ((width * height) * pricePerM2);

    return lenghtWallsPrice + widthWallsPrice + ceilingPrice;
}

double pricePerM2 = double.Parse(Console.ReadLine());

double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

Console.WriteLine(Calculate(lenght, width, height, pricePerM2));

