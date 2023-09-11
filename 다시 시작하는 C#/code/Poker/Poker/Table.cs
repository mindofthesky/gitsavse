using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Table
    {
        public List<Card> cards { get; set; }
        public int pos { get; set; }
        public Table(Deck deck) 
        {
            pos = 0;
            cards = new List<Card>();
            for (int i = 0;i<5; i++)
            {
                cards.Add(deck.dealCard());
            }
        }
        public void placeCard(Deck deck)
        {
            cards.Add(deck.dealCard());
        }
        public void newTable(Deck deck)
        {
            pos = 0;
            cards = new List<Card>();
            for (int i = 0; i<3; i++)
            {
                cards.Add(deck.dealCard());
            }
        }

    }
}
