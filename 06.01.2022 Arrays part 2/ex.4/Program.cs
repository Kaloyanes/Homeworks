int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < array.Length; i++)
{
    array[i]++;
    Console.Write($"{array[i]} ");
}