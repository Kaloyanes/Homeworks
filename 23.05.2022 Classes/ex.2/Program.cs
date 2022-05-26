namespace ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Totally not copied from ex.1
            
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var Args = Console.ReadLine().Split();

                var person = new Person(Args[0], Args[1], int.Parse(Args[2]), double.Parse(Args[3]));

                persons.Add(person);
            }

            var bonus = double.Parse(Console.ReadLine());

            // Empty line just because it's beautiful :) 
            Console.WriteLine("");

            foreach (var person in persons)
            {
                if (person.FirstName.Length < 3)
                {
                    Console.WriteLine("First name cannot be less than 3 symbols");
                    return;
                }

                if (person.LastName.Length < 3)
                {
                    Console.WriteLine("Last name cannot be less than 3 symbols");
                    return;
                }

                if (person.Age <= 0)
                {
                    Console.WriteLine("Age cannot be zero or negative integer");
                    return;
                }

                if (person.Salary < 460)
                {
                    Console.WriteLine("Salary cannot be less than 460 leva");
                    return;
                }

                person.IncreaseSalary(bonus);
                Console.WriteLine(person.ToString());
            }
        }
    }
}