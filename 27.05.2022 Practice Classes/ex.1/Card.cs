using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._1
{
    class Card
    {
        public string Suit { get; private set; }
        public int Power { get; private set; }

        public Card(string suit, int power)
        {
            Suit = suit;
            Power = power;
        }
    }
}
