double CalculatePeople(int peoplePerKm, double size)
{
    return peoplePerKm * size;
}

int peoplePerKm = int.Parse(Console.ReadLine());
double size = int.Parse(Console.ReadLine());

Console.WriteLine(CalculatePeople(peoplePerKm, size));
