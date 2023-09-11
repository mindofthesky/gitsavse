using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Poker
{
    internal class combinations
    {
        // 정확히는 카드 값을 이제 player 에게 호출해주는 역할 
        // 탑, 원페어, 투페어, 트리플, 포카드, 플러쉬, 같은 값이 있을 수있으니 결과에 승리의 룰에 대한 부분과 비슷하다 
        // 여기 단점은 에러가 있을수 있는걸 완벽히 처리 하지않았다는것이고 
        
        public static int[] GetRepeated(List<Card> cards)
        {
            int[] Repeated = {0,0,0,0,0,0,0,0,0,0,0,0,0,0 };

            foreach(Card card in cards)
            {
                Repeated[card.value]++;
            }
            return Repeated;
        }
        // 가장 좋은 생각은 sort를 한번하고 실행을해야 가장 좋을것같거든? 근데 sort 
        public static bool isPair(List<Card> list, Player player)
        {
            int[] Repeated = GetRepeated(list);
            for (int i = Repeated.Length -1; i>0; i++) {
                if (Repeated[i] == 2) 
                {
                    player.combinationHighCardValue = i;
                }
            }
            return false;
        }
        public static bool isThreeOfKind(List<Card> list, Player player)
        {
            int[] Repeated = GetRepeated(list);
            for (int i = Repeated.Length -1; i>0; i--)
            {
                if (Repeated[i] == 3)
                {
                    player.combinationHighCardValue = i;
                    return true;
                }
            }
            return false;
        }
        public static bool isfourofkind(List<Card> list, Player player)
        {
            int[] Repeated =GetRepeated(list);
            for(int i = Repeated.Length -1; i>0; i--)
            {
                if (Repeated[i] == 4)
                {
                    player.combinationHighCardValue = i;
                    return true;
                }
            }
            return false;
        }
        public static bool isflush(List<Card> cards, Player player) 
        {
            List<int> suitValue = new List<int>();
            int highest = 0;
            foreach(Card card in cards)
            {
                if(highest < card.value) highest = card.value;
                suitValue.Add((int)card.cardsuit);
            }
            suitValue.Sort();
            if (suitValue[0] == suitValue[4])
            {
                player.combinationHighCardValue = highest;
                return true;
            }
            return false;
        }
        public static bool almostraight(List<Card> cards)
        {
            // 스트레이트에 다양한 경우를 판정하는건 간단하나 제일 썐놈도 판정해줘야함 
            List<int> cardValue = new List<int>();
            foreach(Card card in cards)
            {
                cardValue.Add(card.value);
            }
            cardValue.Sort();
            int consequative = 0;
            int hightest = 0;
            bool isstraightBool = false;
            for(int i = 0; i<cardValue.Count - 1; i++)
            {
                if (cardValue[i] == cardValue[i+1] - 1)
                {
                    consequative++;
                    if (consequative == 3)
                    {
                        isstraightBool = true;
                    }
                    else consequative = 0;
                }
            }

            return isstraightBool;
        }
        public static bool isStraight(List<Card> cards, Player player) 
        {
            // 제일쌘 스트레이트 
            List<int> cardValues = new List<int>();
            foreach(Card card in cards)
            {
                cardValues.Add(card.value);
            }
            cardValues.Sort();
            int consequative = 0;
            int hightest = 0;
            bool isstraightBool = false;
            for (int i = 0;i<cardValues.Count - 1;i++)
            {
                if (cardValues[i] == cardValues[i+1] - 1)
                {
                    if (cardValues[i+1] > hightest) hightest = cardValues[i+1];

                    consequative += 1;
                    if (consequative == 4)
                        isstraightBool =true;

                }
                else
                {
                    consequative = 0;
                }
            }
            if (isstraightBool) player.combinationHighCardValue = hightest;
            return isstraightBool;
        }
        public static bool isfullhouse(List<Card> cards, Player player)
        {
            int[] repeated = GetRepeated(cards);
            if(repeated.Contains(2) && repeated.Contains(3))
            {
                int index2 = Array.IndexOf(repeated, 2);
                int index3 = Array.IndexOf(repeated, 3);

                for (int i = 0; i < repeated.Length; i++)
                {
                    if (repeated[i] == 3 || i > index3) index3 = i;
                    if (repeated[i] ==2  || i < index2) index2 = i;
                }
                player.combinationHighCardValue = index2 > index3 ? index2 : index3;
                return true;
            }
            return false;
        }
        public static bool istwopair(List<Card> cards, Player player)
        {
            int[] repeated = GetRepeated(cards);
            bool flag = false;
            bool finalvalue = false;
            int highest = 0;
            for(int i = 0; i < repeated.Length; i++) 
            {
                if (repeated[i] == 2)
                {
                    if (highest <i)
                    {
                        highest = i;
                    }
                    if(flag == true)
                    {
                        highest = highest >i ? highest : i;
                        finalvalue = true;
                    }
                    flag = true;
                }
            }
            player.combinationHighCardValue = highest;
            return finalvalue;
        }
        /*
         * 플레이어 A, B가 높은 수가 승리하는데 A인경우 카드 밸류를 이해합니다
         *  Ace 2  ~ 10, jack,queen, king,  14
         */
        public static int isBetter(Player player1, Player player2)
        {
            int p1HighCard = player1.card1.value > player1.card2.value ? player1.card1.value : player1.card2.value;
            int p2HighCard = player2.card1.value > player2.card2.value ? player2.card1.value : player2.card2.value;
            if ((int)player1.playerCombination == (int)player2.playerCombination) 
            {

                if (player1.combinationHighCardValue == player2.combinationHighCardValue) 
                {
                    if (p1HighCard == p2HighCard)
                    {
                        return 0;
                    }
                    return p1HighCard > p2HighCard ? 1 : 2;
                }
                if (player1.combinationHighCardValue > player2.combinationHighCardValue)
                    return 1;
                else return 2;
            }
           
            if ((int)player1.playerCombination > (int)player2.playerCombination) 
                return 1;
            return 2;
        }
        }
}
