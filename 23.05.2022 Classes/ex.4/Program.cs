namespace ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            var products = new List<Product>();

            var personCommands = Console.ReadLine().Trim().Split(';');
            foreach (var personCommand in personCommands)
            {
                var personInfo = personCommand.Split('=');

                var person = new Person(personInfo[0], double.Parse(personInfo[1]));
                persons.Add(person);
            }

            var productsCommands = Console.ReadLine().Trim().Split(';');
            foreach (var productsCommand in productsCommands)
            {
                var productsInfo = productsCommand.Split('=');

                var product = new Product(productsInfo[0], double.Parse(productsInfo[1]));
                products.Add(product);
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Trim().Split();
                if (commands[0] == "END")
                {
                    break;
                }

                var name = commands[0];
                var product = commands[1];

                // check if person exists
                var person = persons.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    Console.WriteLine("Person doesn't exist");
                    continue;
                }

                // check if product exists
                var productToBuy = products.FirstOrDefault(p => p.Name == product);

                if (productToBuy == null)
                {
                    Console.WriteLine("Product doesn't exist");
                    continue;
                }

                person.BuyProduct(productToBuy);
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}