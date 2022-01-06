int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(array.Max() - array.Min());