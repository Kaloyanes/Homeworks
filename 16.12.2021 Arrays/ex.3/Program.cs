var arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
var search = int.Parse(Console.ReadLine());

int count = 0;
foreach (var i in arr)
{
    if (i == search)
        count++;
}

Console.WriteLine(count);