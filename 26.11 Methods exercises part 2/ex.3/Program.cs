double CalculateHours(int averageSpeed, int distance)
{
    return Math.Ceiling((double)averageSpeed / distance);
}

int averageSpeed = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());

Console.WriteLine($"{CalculateHours(averageSpeed, distance):F2}h");
