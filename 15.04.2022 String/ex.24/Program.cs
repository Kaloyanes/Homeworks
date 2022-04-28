string[] file = Console.ReadLine().Trim().Split('.');
string[] allowedFile = Console.ReadLine().Trim().Split(',');

if (allowedFile.Contains(file[file.Length - 1]))
{
    Console.WriteLine("Allowed");
    return;
}

Console.WriteLine("Not allowed");