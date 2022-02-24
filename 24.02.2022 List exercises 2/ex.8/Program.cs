List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

List<int> aboveAverage = new List<int>();
List<int> belowAverage = new List<int>();

nums.ForEach(x =>
{
    if(x > nums.Average())
    {
        aboveAverage.Add(x);
    }
    else
    {
        belowAverage.Add(x);
    }
});

Console.WriteLine(String.Join(" ", belowAverage));
Console.WriteLine(String.Join(" ", aboveAverage));
