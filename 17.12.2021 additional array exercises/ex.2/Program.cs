var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

var nums = new int[65536];

foreach (var i in input)
    nums[i]++;

Console.WriteLine(Array.IndexOf(nums, nums.Max()));