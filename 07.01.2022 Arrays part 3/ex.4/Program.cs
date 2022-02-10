int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

List<int> sorted = new List<int>();

if (input.Length == 1)
    sorted.Add(input[0]);

else if (input.Length % 2 == 1)
{
    sorted.Add(input[input.Length / 2 - 1]);
    sorted.Add(input[input.Length / 2]);
    sorted.Add(input[input.Length / 2 + 1]);
}

else
{
    sorted.Add(input[input.Length / 2 - 1]);
    sorted.Add(input[input.Length / 2]);
}

Console.WriteLine("{ " + string.Join(", ", sorted) + " }");