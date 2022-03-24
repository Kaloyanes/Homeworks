using ex._2;

var pb = new Phonebook();
while (true)
{
    var input = Console.ReadLine().Trim().Split();

    switch (input[0])
    {
        case "A": // Add a new contact
        case "U": // Update contact
            pb.AddPhone(input[1], input[2]);
            break;

        case "ListAll":
            Console.WriteLine("");
            pb.ListAll();
            Console.WriteLine("");
            break;

        case "END":
            return;
    }
}