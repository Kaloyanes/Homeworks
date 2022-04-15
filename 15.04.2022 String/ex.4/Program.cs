char[] chars = new[] { 'a', 'e', 'o', 'u', 'i', 'y' };

string input = Console.ReadLine();
int count = 0;

foreach (char c in input)
{
    if(chars.Contains(c))
        count++;
}

Console.WriteLine(count);
