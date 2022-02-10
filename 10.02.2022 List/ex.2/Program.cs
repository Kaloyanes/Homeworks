List<int> list = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

for(int i = 0; i < list.Count; i++)
    Console.WriteLine($"List[${i}] = {list[i]}");