namespace ex._2;

public class Phonebook
{
    private SortedDictionary<string, string> phonebook = new ();

    public void AddPhone(string name, string phone)
    {
        phonebook[name] = phone;
    }

    public void ListAll()
    {
        foreach (var pair in phonebook.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}