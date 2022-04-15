Dictionary<char, int> dict = new Dictionary<char, int>();

string input = Console.ReadLine();
foreach (char c in input)
{
    if (!dict.ContainsKey(c))
    {
        dict.Add(c, 1);
    }
}

Console.WriteLine(dict.Sum(i => i.Value));