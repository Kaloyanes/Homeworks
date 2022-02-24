var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

input.RemoveAll(x => x < 0);
Console.WriteLine(string.Join(" ", input));