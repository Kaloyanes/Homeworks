var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

var last = input[input.Count - 1];

input.RemoveAll(x => x == last);
Console.WriteLine(string.Join(" ", input));