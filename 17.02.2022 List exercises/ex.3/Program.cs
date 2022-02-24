var lists = Console.ReadLine()
    .Trim()
    .Split("|")
    .Select(s => s.Trim())
    .Reverse()
    .ToList();

Console.WriteLine(string.Join(" ", lists));