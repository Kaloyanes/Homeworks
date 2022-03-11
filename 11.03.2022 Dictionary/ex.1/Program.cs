Dictionary<string, int> dict = new Dictionary<string, int>();
string[] words = Console.ReadLine().Trim().Split().ToArray();

foreach (string word in words)
{
    var lower = word.ToLower();

    if(!dict.ContainsKey(lower))
        dict.Add(lower, 0);

    dict[lower]++;
}

foreach (var pair in dict.Where(x => x.Value % 2 != 0))
{
    Console.Write($"{pair.Key}, ");
}