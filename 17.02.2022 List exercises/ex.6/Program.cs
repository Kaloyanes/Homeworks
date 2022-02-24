var nums = Console.ReadLine()
    .Trim()
    .Split()
    .Select(int.Parse)
    .ToList();

Dictionary<int, int> numsDict = new Dictionary<int, int>();

nums.Sort();
foreach (var i in nums)
{
    if (!numsDict.ContainsKey(i)){
        numsDict.Add(i, 1);
        continue;
    }
    
    numsDict[i]++;
}


foreach (var (key, value) in numsDict)
{
    Console.WriteLine($"{key} -> {value}");
}