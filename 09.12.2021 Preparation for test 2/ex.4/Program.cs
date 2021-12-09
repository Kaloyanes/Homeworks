{
    int count = int.Parse(Console.ReadLine());

    List<double> scales = new List<double>()
    {
        0,0,0,0
    };

    for (int i = 0; i < count; i++)
    {
        double input = double.Parse(Console.ReadLine());

        if (input > 0 && input<= 4)
            scales[0]++;

        else if (input <= 6)
            scales[1]++;

        else if (input <= 7)
            scales[2]++;

        else
            scales[3]++;
    }

    for (int i = 0; i < scales.Count; i++)
        scales[i] = scales[i] / count * 100;

    Console.WriteLine($"Light: {scales[0]:F2}%");
    Console.WriteLine($"Moderate: {scales[1]:F2}%");
    Console.WriteLine($"Strong: {scales[2]:F2}%");
    Console.WriteLine($"Very strong: {scales[3]:F2}%");
}