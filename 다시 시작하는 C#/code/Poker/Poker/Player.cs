using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Poker.Player;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Poker
{
    internal class Player
    {
        public enum action
        {
            call, 
            check,
            fold
        }
        public enum combination
        {
            highCard = 1,
            pair = 2,
            twoPair = 3,
            threeOfKind = 4,
            straight = 5,
            flush = 6,
            fullHouse = 7,
            fourOfKind = 8,
            straightFlush = 9,
            royalFlush = 10
        }
        public Card card1 { get; set; }
        public Card card2 { get; set; }
        public int money { get; set; }
        public Table table { get; set; }
        public combination playerCombination
        {
            get
            {

                List<Card> allCards = new List<Card>();

                allCards.Add(card1);
                allCards.Add(card2);

                allCards = allCards.Concat(table.cards).ToList();
                
                if (combinations.isStraight(allCards, this) && combinations.isflush(allCards, this)) return combination.straightFlush;
                if (combinations.isfourofkind(allCards, this)) return combination.fourOfKind;
                if (combinations.isfullhouse(allCards, this)) return combination.fullHouse;
                if (combinations.isflush(allCards, this)) return combination.flush;
                if (combinations.isStraight(allCards, this)) return combination.straight;
                if (combinations.isThreeOfKind(allCards, this)) return combination.threeOfKind;
                if (combinations.istwopair(allCards, this)) return combination.twoPair;
                if (combinations.isPair(allCards, this)) return combination.pair;
                combinationHighCardValue = card1.value > card2.value ? card1.value : card2.value;
                return combination.highCard;
            }
        }
        public int getHighestCard(List<Card> cards)
        {
            int highest = 2;
            foreach (Card card in cards)
            {
                if (highest < card.value)
                    highest = card.value;
            }
            return highest;
        }
        public int combinationHighCardValue;
        public string Name { get; set; }
        public action currentAction { get; set; }
        public void removeMoney(int given)
        {
            money -= given;
        }
        public void giveMoney(int give)
        {
            money += give;
        }

        public Player(Table t)
        {
            table = t;
            money = 1000;
        }

    }
}

