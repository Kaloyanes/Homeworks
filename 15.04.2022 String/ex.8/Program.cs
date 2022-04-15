string input = Console.ReadLine().Trim();

char[] inputArr = input.ToCharArray();
Array.Reverse(inputArr);
string reversed = new string(inputArr);

if (input == reversed)
{
    Console.WriteLine("yes");
    return;
}

Console.WriteLine("no");
