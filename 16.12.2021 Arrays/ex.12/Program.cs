var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var search = int.Parse(Console.ReadLine());

int count = 0;
foreach (var i in arr)
{
    if (i == search)
        break;

    count++;
}

Console.WriteLine(count != 0 ? count : "Not found");