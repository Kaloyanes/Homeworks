using ex._3;

List<Person> people = new List<Person>();


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    people.Add(new Person(input[0], int.Parse(input[1])));
}

foreach (var person in people.Where(p => p.Age > 30).OrderBy(p => p.Name))
{
    Console.WriteLine(person.ToString());
}