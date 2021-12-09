double Calculate(double width, double lenght, int cameras, string name)
{
    Dictionary<string, int[]> companies = new Dictionary<string, int[]>()
    {
        {"dogramichka4you", new []{12,15,20}},
        {"tihotoplo", new []{15,14,18}},
        {"chukchuk", new []{14,20,22}}
    };

    var area = width * lenght;
    var values = companies[name.ToLower()];


    return area * values[cameras - 3];
}

{
    double width = double.Parse(Console.ReadLine());
    double lenght = double.Parse(Console.ReadLine());
    int cameras = int.Parse(Console.ReadLine());
    string name = Console.ReadLine();

    double price = Calculate(width, lenght, cameras, name);

    Console.WriteLine($"Goshko has to spend {price:F2} leva.");
}