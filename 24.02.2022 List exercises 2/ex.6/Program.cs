List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

input.ForEach(i =>
{
    if(!result.Contains(i)) result.Add(i);
});

Console.WriteLine(String.Join(' ', result));