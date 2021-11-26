int CalculatePeople(int peoplePerKm, int size)
{
    return peoplePerKm * size;
}

int peoplePerKm = int.Parse(Console.ReadLine()), size = int.Parse(Console.ReadLine());

Console.WriteLine(CalculatePeople(peoplePerKm, size));