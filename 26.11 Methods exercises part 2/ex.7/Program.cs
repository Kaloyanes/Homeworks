double CalculatePeople(double peoplePerKm, double size)
{
    return peoplePerKm * size;
}

double peoplePerKm = double.Parse(Console.ReadLine());
double size = double.Parse(Console.ReadLine());

Console.WriteLine(CalculatePeople(peoplePerKm, size));
