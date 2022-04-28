string CensorWord = Console.ReadLine().Trim();
string Text = Console.ReadLine().Trim();

string censoredText = Text.Replace(CensorWord, new string('*', CensorWord.Length));
Console.WriteLine(censoredText);