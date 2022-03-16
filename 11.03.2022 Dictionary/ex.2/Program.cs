
// Global variable
Dictionary<string, string> phonebook = new Dictionary<string, string>();

void AddPhone(string name, string phoneNumber)
{
    Console.WriteLine($"Added {name} to the phonebook.");

    if (!phonebook.ContainsKey(phoneNumber))
    {
        phonebook.Add(name, phoneNumber);
        return;
    }

    phonebook[name] = phoneNumber;
}

void SearchPhone(string contact)
{
    if (!phonebook.ContainsKey(contact))
    {   
        Console.WriteLine($"Contact {contact} does not exist.");
        return;
    }

    Console.WriteLine($"{contact} -> {phonebook[contact]}");
}

while (true)
{
    // Взимаме командите и аргументите
    // Използваме Array понеже използва по-малко ресурси от List-a
    string[] command = Console.ReadLine().Trim().Split();

    // Добре де признавам, че в случая switch е по-добре
    switch (command[0].ToLower())
    {
        case "a":
            AddPhone(command[1], command[2]);
            break;

        case "s":
            SearchPhone(command[1]);
            break;

        case "end":
            return;

        default:
            Console.WriteLine("Unknown Command");
            break;
    }
    
    Console.WriteLine("");
}