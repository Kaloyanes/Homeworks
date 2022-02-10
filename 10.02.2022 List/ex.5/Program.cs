List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

foreach (var num in nums)
{
    if(num % 2 == 0) Console.Write(num + " ");
}