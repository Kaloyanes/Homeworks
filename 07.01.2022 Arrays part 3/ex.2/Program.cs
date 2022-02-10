var arr = Console.ReadLine().Split().ToArray();

int errorCount = 0;
while (true)
{
    var cmd = Console.ReadLine().Trim().Split().ToArray();

    if (cmd[0].ToLower() == "end")
        break;


    switch (cmd[0].ToLower())
    {
        case "reverse":
            arr = arr.Reverse().ToArray();
            break;

        case "distinct":
            arr = arr.Distinct().ToArray();
            break;

        case "replace":
            if (int.Parse(cmd[1]) < 0 || int.Parse(cmd[1]) > arr.Length)
            {
                errorCount++;
                break;
            }
            arr[int.Parse(cmd[1])] = cmd[2];
            break;
    }
}

for (int i = 0; i < errorCount; i++)
    Console.WriteLine("Invalid input");

Console.WriteLine(string.Join(" ", arr));