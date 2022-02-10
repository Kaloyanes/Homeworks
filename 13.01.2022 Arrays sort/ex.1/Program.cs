var input1 = Console.ReadLine().Trim().Split().Select(char.Parse).ToArray();
var input2 = Console.ReadLine().Trim().Split().Select(char.Parse).ToArray();

if (input1 == input2)
{
    Console.WriteLine(string.Join(" ", input1));
    Console.WriteLine(string.Join(" ", input1));
}

if (input1.Length < input2.Length)
{
    Console.WriteLine(string.Join(" ", input1));
    Console.WriteLine(string.Join(" ", input2));
    return;
}

else if (input1.Length > input2.Length)
{
    Console.WriteLine(string.Join(" ", input2));
    Console.WriteLine(string.Join(" ", input1));
    return;
}


for (int i = 0; i < input1.Length; i++)
{
    if (input1[i] == input2[i])
        continue;

    else if (input1[i] < input2[i])
    {
        Console.WriteLine(string.Join(" ", input1));
        Console.WriteLine(string.Join(" ", input2));
        break;
    }

    else
    {
        Console.WriteLine(string.Join(" ", input2));
        Console.WriteLine(string.Join(" ", input1));
        break;
    }
}