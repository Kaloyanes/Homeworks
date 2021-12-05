string Calculate(int capacityResturant, int groups)
{
    int sum = 0;
    for (int i = 0; i < groups; i++)
    {
        int input = int.Parse(Console.ReadLine());
        sum += input;
    }

    int capacity = Math.Abs(sum - capacityResturant);
    
    if (sum <= capacityResturant)
        return $"You have {sum} guests and {capacity} free chairs left.";

    return $"You have {sum} guests and {capacity} more chairs needed.";
}

int capacityResturant = int.Parse(Console.ReadLine());
int groups = int.Parse(Console.ReadLine());


Console.WriteLine(Calculate(capacityResturant, groups));