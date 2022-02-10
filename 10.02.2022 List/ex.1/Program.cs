var list = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

for (var i = 0; i < list.Count; i++)
    Console.WriteLine($"List[${i}] = {list[i]}");