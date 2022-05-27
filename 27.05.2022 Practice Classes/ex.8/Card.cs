using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._8
{
    public class Card
    {
        public string Suit { get; private set; }
        public int Power { get; private set; }

        public Card(int power, string suit)
        {
            Power = power;
            Suit = suit;
        }

        public override string ToString()
        {
            switch (Power)
            {
                case 14:
                    Suit = "Ace";
                    break;
                case 13:
                    Suit = "King";
                    break;
                case 12:
                    Suit = "Queen";
                    break;
                case 11:
                    Suit = "Jack";
                    break;
            }

            return $"{Suit} of {Power}";
        }
    }
}
