Dictionary<char, int> chars = new Dictionary<char, int>();
string input = Console.ReadLine();

foreach (var c in input)
{
    if (!chars.ContainsKey(c))
        chars[c] = 0;
    
    chars[c]++;
}

foreach (var pair in chars)
{
    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
}