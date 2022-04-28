string input = Console.ReadLine().Trim();
bool found = false;

for (int i = 0; i < input.Length; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] == input[j])
        {
            Console.WriteLine($"{input[i]} {i} {j}");
            found = true;
            break;
        }
    }
    if (found)
    {
        break;
    }
}

if (!found)
{
    Console.WriteLine("No");
}
