double CalculateHours(int distance, int averageSpeed)
{
    return (double)averageSpeed / distance;
}

int distance = int.Parse(Console.ReadLine());
int averageSpeed = int.Parse(Console.ReadLine());

Console.WriteLine($"{CalculateHours(distance, averageSpeed):F2}");
