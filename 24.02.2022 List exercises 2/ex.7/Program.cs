List<double> answers = Console.ReadLine()
    .Trim()
    .Split()
    .Select(double.Parse)
    .ToList();
    // .Select(x => Math.Round(x, 2))

double sum = answers.Sum();

if (answers.Sum() == 0.99)
    sum = Math.Round(sum);

if (sum == 1)
    Console.WriteLine("OK");
    
else
    Console.WriteLine("The sum is not 100%");