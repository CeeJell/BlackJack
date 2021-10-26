using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private int _nrOfDecks;
        private List<Card> _cards;
        public Random _random = new Random();

        public Deck(int nrOfDecks)
        {
            _nrOfDecks = nrOfDecks;
            ResetAndShuffle();
        }

        public void ResetAndShuffle()
        {

            _cards = new List<Card>();
            for (int decks = 0; decks < _nrOfDecks; decks++)    
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    for (int i = 1; i < 14; i++)
                    {
                        _cards.Add(new Card(i, (SuitType)suit));
                    }
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            List<Card> tmpDeck = new List<Card>();
            while (_cards.Count > 0)
            {
                int index = _random.Next(_cards.Count);
                Card tmpCard = _cards[index];
                tmpDeck.Add(tmpCard);
                _cards.RemoveAt(index);
            }
            _cards = tmpDeck;
        }

        public Card Draw()
        {
            Card card = _cards[_cards.Count - 1];
            _cards.Remove(card);
            return card;
        }

    }
}
