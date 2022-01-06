int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int temp = array[0];
array[0] = array[array.Length - 1];
array[array.Length - 1] = temp;

foreach (var i in array)
    Console.Write($"{i} ");