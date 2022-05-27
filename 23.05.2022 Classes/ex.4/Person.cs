namespace ex._4;

public class Person
{
    public string Name { get; set; }
    public double Money { get; set; }
    public List<Product> Bag { get; set; }

    public Person(string name, double money)
    {
        Name = name;
        Money = money;
        Bag = new List<Product>();
    }

    public void BuyProduct(Product product)
    {
        if (product.Price <= Money)
        {
            Bag.Add(product);
            Money -= product.Price;
            Console.WriteLine($"{Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        return $"{Name} - {string.Join(", ", Bag.Select(x => x.Name))}";
    }
}