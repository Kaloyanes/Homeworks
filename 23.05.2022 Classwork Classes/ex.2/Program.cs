using ex._1;

var family = new Family();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string name = Console.ReadLine().Trim();
    int age = int.Parse(Console.ReadLine());
    family.AddMember(new Person(name, age));
}

Console.WriteLine(family.ToString());