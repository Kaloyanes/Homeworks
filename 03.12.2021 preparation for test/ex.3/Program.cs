{
    string meal = Console.ReadLine();
    string dessert = Console.ReadLine();
    int pizzas = int.Parse(Console.ReadLine());

    Console.WriteLine($"{calculate(meal, dessert, pizzas):F2} lv");
}

double calculate(string meal, string dessert, int pizzas)
{
    double price;
    switch (meal.ToLower())
    {
        case "small":
            price = 9.98;
            break;

        case "middle":
            price = 18.99;
            break;

        case "large":
            price = 25.98;
            break;

        case "extralarge":
            price = 35.99;
            break;

        default:
            throw new ArgumentException("Invalid meal");
    }

    price *= pizzas;

    if (dessert.ToLower() == "yes")
        price += 5;

    if (price > 50)
        return price - (price * 0.1);

    if (price > 25)
        return price - (price * 0.07);

    return price - (price * 0.05);
}