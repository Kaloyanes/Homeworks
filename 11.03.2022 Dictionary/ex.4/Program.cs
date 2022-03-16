List<string> query = new List<string>();

void ShowReceipt()
{
    foreach (var line in query)
    {
        Console.WriteLine(line);
    }
}

double total = 0;

while (true)
{
    string[] info = Console.ReadLine().Trim().Split();


    if (info[0].ToLower() == "stocked")
    {
        Console.WriteLine("");
        query.Add(new string('-', 30));
        query.Add($"Grand Total: ${total:F2}");
        ShowReceipt();
        return;
    }

    total += (double.Parse(info[1]) * int.Parse(info[2]));
    query.Add($"{info[0]}: ${double.Parse(info[1]):F2} * {int.Parse(info[2])} = ${double.Parse(info[1]) * int.Parse(info[2]):F2}");
}