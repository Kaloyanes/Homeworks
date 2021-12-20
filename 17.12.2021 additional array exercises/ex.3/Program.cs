string input = Console.ReadLine();

var alphabet = new List<char>();
for (char i = 'a'; i < 'z'; i++)
    alphabet.Add(i);

foreach (var c in input)
    Console.WriteLine($"{c} {Array.IndexOf(alphabet.ToArray(), c)}");