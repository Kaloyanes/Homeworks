var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int sum = 0;
foreach (var i in arr)
{
    if (i < 0)
        sum += i;
}

Console.WriteLine(sum);