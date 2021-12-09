int n = int.Parse(Console.ReadLine());

for (int i = 0; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        if (j % 3 != 0 && j != 1)
            continue;

        for (int k = 0; k < 10; k++)
        {
            if (k != 4 && k != 7)
                continue;

            for (int l = 0; l < 10; l++)
            {
                if (i + l != n)
                    continue;

                Console.WriteLine($"{i}{j}{k}{l}");
            }
        }
    }
}