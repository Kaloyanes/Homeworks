int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int max = array.Max();
int counter = 0;

foreach (var i in array)
    if (i == max)
        counter++;


Console.WriteLine(counter);