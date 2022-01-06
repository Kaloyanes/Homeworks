var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

if (input.Length == 1)
{
    Console.WriteLine($"{input[0]} is already a condensed to a number");
    return;
}

int[] condesned = new int[input.Length - 1];

int i = 0;
while (true)
{
    if (input.Length == 1)
        break;

    if (i + 1 == input.Length)
        i = 0;

    condesned[i] = input[i] + input[i + 1];
    input = condesned;
    i++;
}

Console.WriteLine(condesned[0]);