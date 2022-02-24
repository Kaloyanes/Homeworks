List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

List<int> result = new List<int>();

nums.ForEach(x =>
{
    string i = x.ToString();
    if(i[i.Length - 1] == '0') result.Add(x);
});

Console.WriteLine(string.Join(" ", result));
