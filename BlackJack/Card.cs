using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public int Value { get; set; }
        public SuitType Suit { get; set; }
        public int BlackJackValue { get; set; }
        public string Face;

        public Card(int value, SuitType suit)
        {
            Value = value;
           
            Suit = suit;
        }

        public override string ToString()
        {
            if (Value == 11) Face = "Kn";
            else if (Value == 12) Face = "Q";
            else if (Value == 13) Face = "K";
            else if (Value == 1) Face = "A";
            else
            {
                Face = Value.ToString();
            }
            return $"{Face} of {Suit}";
        }

    }
}
