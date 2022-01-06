int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int min = array.Min();
int counter = 0;

foreach (var i in array)
    if (i == min)
        counter++;


Console.WriteLine(counter);