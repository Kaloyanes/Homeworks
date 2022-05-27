namespace ex._4;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        if (name.Length == 0)
        {
            Console.WriteLine("Name can't be empty");
            return;
        }

        if (price < 0)
        {
            Console.WriteLine("Price can't be negative");
            return;
        }

        Name = name;
        Price = price;
    }
}