var nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

var max = nums.Max();
var min = nums.Min();

var maxCount = 0;
var minCount = 0;

nums.ForEach(x =>
{
    if (x == max) maxCount++;
    else if (x == min) minCount++;
});

for (var i = 0; i < maxCount; i++)
    Console.Write(max + " ");

for (var i = 0; i < minCount; i++)
    Console.Write(min + " ");