var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

int[] condesed = new int[input.Length];

for (int i = 0; i < input.Length; i++)
    condesed[i] = input[i] + input[i + 1];

Console.WriteLine(condesed[0]);