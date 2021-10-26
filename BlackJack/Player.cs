using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public List<Card> Hand = new List<Card>();
        
        public Card LastDrawnCard;

        public int LowValue
        {
            get
            {
                int result = 0;
                foreach (var card in Hand)
                {
                    if (card.Value > 9)
                    {
                        result += 10;
                    }
                    else
                    {
                        result += card.Value;
                    }
                }
                return result;
            }
        }

        public int HighValue
        {
            get
            {
                int result = 0;
                foreach (var card in Hand)
                {
                    if (card.Value == 1)
                    {
                        result += 11;
                    }
                    else if (card.Value > 9)
                    {
                        result += 10;
                    }
                    else
                    {
                        result += card.Value;
                    }
                }
                return result;
            }

        }

        public int BestValue
        {
            get
            {
                if (HighValue > 21)
                {
                    return LowValue;
                }
                else return HighValue;
            }
        }


        public void Reset()
        {
            Hand = new List<Card>();
        }

        public override string ToString()
        {
            return $"LowValue {LowValue}; HighValue {HighValue}; BestValue {BestValue}";
        }


    }
}
