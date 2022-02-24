List<int> nums = Console.ReadLine().Trim().Split().Select(int.Parse).Reverse().ToList();

Console.WriteLine(String.Join(" ", nums));