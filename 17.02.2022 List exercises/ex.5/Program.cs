var nums = Console.ReadLine()
    .Trim()
    .Split()
    .Select(int.Parse)
    .ToList();

nums.Sort();

for (var i = 0; i < nums.Count - 1; i++)
    Console.Write(nums[i] + " <= ");

Console.WriteLine(nums[nums.Count - 1]);