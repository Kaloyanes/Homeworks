namespace ex._8;

public class Deck
{
    private List<Card> Cards = new List<Card>();

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    public Card PullCard()
    {
        var card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }

    public void Shuffle()
    {
        var rnd = new Random();
        for (int i = 0; i < Cards.Count; i++)
        {
            var j = rnd.Next(i, Cards.Count);
            var temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = temp;
        }
    }

    public override string ToString()
    {
        string result = "";
        foreach (var card in Cards)
        {
            result += card.ToString() + "\n";
        }

        return result;
    }
}