using System.Text;

string word = Console.ReadLine().Trim();
int times = int.Parse(Console.ReadLine().Trim());

StringBuilder sb = new StringBuilder(word);
string wordToRepeat = word;

for (int i = 1; i < times; i++)
{
    sb.Append(wordToRepeat);
}

Console.WriteLine(sb.ToString());