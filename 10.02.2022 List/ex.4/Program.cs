static string Reverse(string name)
{
    var nameWords = name.Trim().Split(' ');
    return nameWords[1] + " " + nameWords[0];
}

var names = Console.ReadLine().Trim().Split(',').ToList();
foreach (var name in names)
{
    var reverse = Reverse(name);
    Console.WriteLine(reverse);
}