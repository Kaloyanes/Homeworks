var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine($"{arr.Min()} {Array.IndexOf(arr, arr.Min())}");