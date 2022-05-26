namespace ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                person.IncreaseSalary(bonus);
                Console.WriteLine(person.ToString());
            }
        }
    }
}