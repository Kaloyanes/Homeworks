var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int count = 0;
foreach (var i in arr)
{
    if (i > 0)
        count++;
}

Console.WriteLine(count);