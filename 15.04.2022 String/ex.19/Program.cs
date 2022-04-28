string[] input = Console.ReadLine().Trim().Split('.');

if (input.Length == 1)
{
    Console.WriteLine("No extension");
    return;
}

Console.WriteLine(input[input.Length - 1]);