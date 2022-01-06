int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
double average = (double)array.Sum() / array.Length;

List<int> biggerAverage = new List<int>();

foreach (var i in array)
    if (i >= average)
    {
        biggerAverage.Add(i);
        Console.Write($"{i} ");
    }