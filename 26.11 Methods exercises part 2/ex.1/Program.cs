double Average(params int[] numbers)
{
    double sum = numbers.Sum();

    return (sum / numbers.Length) * 1.0;
}

{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int n3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"{Average(n1, n2, n3):F2}");
}