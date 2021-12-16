var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
var search = int.Parse(Console.ReadLine());

bool found = false;
foreach (var i in arr)
{
    if (i == search)
        found = true;
}

Console.WriteLine(found ? "Yes" : "No");