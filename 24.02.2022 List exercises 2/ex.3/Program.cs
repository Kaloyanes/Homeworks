List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
List<int> input2 = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();

List<int> results = new List<int>();

for(int i = 0, j = 0; i < input.Count && j < input2.Count; i++, j++)
{
    results.Add(input[i]);
    results.Add(input2[j]);
}

if (input.Count > input2.Count)
{
    for (int i = input2.Count; i < input.Count; i++)
    {
        results.Add(input[i]);
    }
}
else
{
    for (int i = input.Count; i < input2.Count; i++)
    {
        results.Add(input2[i]);
    }
}

Console.WriteLine(String.Join(" ", results));