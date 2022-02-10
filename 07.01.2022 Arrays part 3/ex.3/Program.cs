int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

int[] arr = new int[n];
arr[0] = 1;
arr[1] = 1;


for (int i = 1; i < n; i++)
{
    int sum = 0;

    for (int j = k; j >= 0; j++)
    {
        if (i - k < 0)
            continue;

        sum += arr[i - k];
    }

    arr[i] = sum;
}

Console.WriteLine(string.Join(" ", arr));