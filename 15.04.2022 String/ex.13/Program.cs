using System.Text;

string input = Console.ReadLine();

int countLetter = 0;
int countDigit = 0;

StringBuilder sb = new StringBuilder();

foreach (var c in input)
{
    bool CanParse = int.TryParse(c.ToString(), out int digit);
    if (CanParse)
    {
        countDigit++;
        continue;
    }

    sb.Append(c);
    countLetter++;
}

if (countLetter > countDigit)
{
    Console.WriteLine(input.ToLower());
    return;
}

char[] charArray = sb.ToString().ToCharArray();
Array.Reverse(charArray);

Console.WriteLine(new string(charArray));