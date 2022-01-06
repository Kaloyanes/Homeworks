int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int temp = array.Max();
array[Array.IndexOf(array, array.Max())] = array.Min();
array[Array.IndexOf(array, array.Min())] = temp;

foreach (var i in array)
    Console.Write($"{i} ");