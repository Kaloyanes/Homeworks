using ex._1;

List<Person> person = new List<Person>();
person.Add(new Person("Pesho", 15));
person.Add(new Person("Gosho", 25));
person.Add(new Person("Tosho 1-50", 30));

person.ForEach(p => Console.WriteLine($"{p.Name} -> {p.Age}"));