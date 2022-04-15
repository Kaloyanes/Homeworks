string input = Console.ReadLine().Trim();
string inputUp = input.ToUpper();

int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == inputUp[i])
        count++;
}

Console.WriteLine(count);