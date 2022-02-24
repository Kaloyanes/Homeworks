List<int> input = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

if(startIndex < 0 || endIndex >= input.Count || startIndex >= endIndex)
{
    Console.WriteLine("Error!");
    return;
}

List<int> result = new List<int>();

for (int i = startIndex; i <= endIndex; i++)
    result.Add(input[i]);

Console.WriteLine(String.Join(" ", result));
