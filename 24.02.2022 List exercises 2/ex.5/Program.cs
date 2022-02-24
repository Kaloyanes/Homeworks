List<double> input = Console.ReadLine().Trim().Split().Select(double.Parse).ToList();
List<double> result = new List<double>();

input.ForEach(i =>
{
    if (i < 0) result.Add(i);
});

Console.WriteLine(String.Join(' ', result));