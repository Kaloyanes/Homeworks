int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
List<int> even = new List<int>();

// НЯМА ДА МЕ НАКАРАТЕ ДА ГО НАПРАВЯ С 2 FOR ЦИКЪЛА

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    {
        even.Add(array[i]);
        Console.WriteLine(array[i]);
    }