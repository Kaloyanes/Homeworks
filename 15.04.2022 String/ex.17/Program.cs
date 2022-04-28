string input1 = Console.ReadLine().Trim();
string input2 = Console.ReadLine().Trim();
int counter = 0;

for (int i = 0; i < input1.Length; i++)
{
    if (input1[i] == input2[0])
    {
        int j = 0;
        bool found = true;
        while (j < input2.Length && i < input1.Length)
        {
            if (input1[i] != input2[j])
            {
                found = false;
                break;
            }
            i++;
            j++;
        }
        if (found)
        {
            counter++;
        }
        i--;
    }
}

Console.WriteLine(counter);