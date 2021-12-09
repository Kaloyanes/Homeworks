int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    for (int j = 0; j <= end; j++)
    {
        for (int k = 0; k <= end; k++)
        {
            for (int l = 0; l <= end; l++)
            {
                if (l % 2 == 0)
                    Console.WriteLine($"{i}{j}{k}{l}");
            }
        }
    }
}