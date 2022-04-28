using System.Text;

char[] chars = new[] { 'a', 'e', 'o', 'u', 'i', 'y' };
string input = Console.ReadLine();

StringBuilder sb = new StringBuilder();

foreach (char c in input)
{
    if (chars.Contains(c))
        sb.Append(c);
}       

Console.WriteLine(sb.ToString());
