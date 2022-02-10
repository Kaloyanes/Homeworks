var arr = Console.ReadLine().Split().ToArray();
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    var cmd = Console.ReadLine().Split().ToArray();

    switch (cmd[0].ToLower())
    {
        case "reverse":
            arr = arr.Reverse().ToArray();
            break;
        case "distinct":
            arr = arr.Distinct().ToArray();
            break;
        case "replace":
            arr[int.Parse(cmd[1])] = cmd[2];
            break;
    }
}
Console.WriteLine(string.Join(" ", arr));