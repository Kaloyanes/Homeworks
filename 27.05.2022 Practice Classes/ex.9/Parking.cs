namespace ex._9;

public class Parking
{
    // Number -> if its free
    List<int> spacesUsed = new List<int>();
    public bool Park(int position)
    {
        if (spacesUsed.Contains(position))
        {
            return false;
        }

        spacesUsed.Add(position);
        return true;
    }
}