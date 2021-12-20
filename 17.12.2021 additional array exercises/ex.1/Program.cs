var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

Console.WriteLine($"Min: {input.Min()}");
Console.WriteLine($"Max: {input.Max()}");
Console.WriteLine($"Sum: {input.Sum()}");
Console.WriteLine($"Average: {input.Average()}");