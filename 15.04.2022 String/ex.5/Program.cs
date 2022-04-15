string input = Console.ReadLine();
int count = 0;

foreach (var c in input)
{
    int num;

    if (int.TryParse(c.ToString(), out num))
    {
        count++;
    }
}

Console.WriteLine(count);