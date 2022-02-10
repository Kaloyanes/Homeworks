var products = Console.ReadLine().Trim().Split().ToArray();
var quanitities = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
var prices = Console.ReadLine().Trim().Split().Select(double.Parse).ToArray();

Queue<int> productQueue = new Queue<int>();

while (true)
{
    var product = Console.ReadLine();

    if (product.ToLower() == "done") break;
    if (!products.Contains(product))
    {
        Console.WriteLine("Product not found");
        continue;
    }

    productQueue.Enqueue(Array.IndexOf(products, product));
}

Console.WriteLine(new string('-', 10));
foreach (var i in productQueue)
    Console.WriteLine($"{products[i]} costs: {prices[i]}; Available quantity: {quanitities[i]}");