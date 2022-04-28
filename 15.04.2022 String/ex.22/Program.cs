using System.Text;

StringBuilder builder = new StringBuilder();
string CensorWord = Console.ReadLine().Trim();
string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == CensorWord[0])
    {
        if (text.Substring(i, CensorWord.Length) == CensorWord)
        {
            builder.Append(new string('*', CensorWord.Length));
            i += CensorWord.Length - 1;
        }
        else
        {
            builder.Append(text[i]);
        }
    }
    else
    {
        builder.Append(text[i]);
    }
}

Console.WriteLine(builder.ToString());