using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        public suit cardsuit {  get; set; }
        public int value
        {
            get; set;
        }

        public Card(suit cardsuits, int cardF)
        {
            this.cardsuit = cardsuit;
            this.value = value;
        }
        public string NameValue
        {
            get
            { 
                string name = string.Empty;
                switch(value)
                {
                    case (14):
                        name = "Ace";
                        break;
                    case (13):
                        name = "king";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "jack";
                        break;
                }
                return name;
            }
            
        }
        public string name
        {
            get
            {
                return NameValue + "of" + cardsuit.ToString();
            }
        }
    }
    public enum suit
    {
        clubs,
        diamonds,
        hearts,
        spades
    }
}
