namespace ex._2;

public class Family
{
    private List<Person> members = new List<Person>();

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public override string ToString()
    {
        string result = "";
        foreach (var member in members.OrderBy(x => x.Name))
        {
            result += member.ToString() + "\n";
        }
        return result;
    }
}