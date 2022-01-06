int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int counter = 0;

foreach (var i in array)
    if (i >= 10 && i < 100)
        counter++;

if (counter == 0)
    Console.WriteLine("No");
else
    Console.WriteLine(counter);