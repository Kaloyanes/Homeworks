List<string> names = Console.ReadLine().Trim().Split().ToList();

List<string> result = new List<string>();

for (int i = 0; i < names.Count; i++)
    if(i % 2 == 0) result.Add(names[i]);

Console.WriteLine(string.Join(" ", result));