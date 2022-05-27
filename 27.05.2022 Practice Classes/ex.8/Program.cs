namespace ex._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var deck = new Deck();
            for (int i = 0; i < 51; i++)
            {
                deck.AddCard(new Card(rnd.Next(1, 15), "Black"));
            }

            deck.Shuffle();

            Console.WriteLine(deck.ToString());
        }
    }
}