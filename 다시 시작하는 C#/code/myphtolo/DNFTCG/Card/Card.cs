using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNFTCG.Card
{

    internal class Card
    {
        // 카드를 통해서 게임을 진행하는 게임이기 때문에 
        // 배열형으로 처리해야하나 동적으로 할당해야 하나 고민을 하게된다 
        // deck 배열적으로 카드의 숫자를 표시한다면, 문제점이 있다 숫자로 덱을 판별할거면 모든 숫자가 나타내는게 있어야한다 
        // string으로 받고 int처럼 Convert를 하는게 낫지않나? 
        private string[] deck = new string[] { }; // 덱

        // 패는 숫자로 int로 선언한이유는 간단하지만 쉽다 패의 소지 매수는 엔드 페이지에 5장으로 만들어야하기 때문에 5장으로 해결할필요가 있다 
        // 패는 직접적으로 효과를 발동 처리부가 아니기때문에 소지 패만 확인 할수만 있어도 충분할거라고 생각한다  23.10.04 
        private int[] hand = new int[] { }; // 패
        // 묘지에서 발동처리하는것은 구현하지 않는다면 묘지는 int로 배열형으로 숫자만 봐도 상관없을것 같다 
        private int[] Gy = new int[] { }; // 묘지
        private string[] banished = new string[] { };
        int level = 0;

        // 카드를 열거형으로 한이유 코드 꼬임이 발생을 방지는 가장 좋은게 열거형이라 생각한다 
        public enum card_effect {
            monster,
            skil,
            cardeffect,
            armor,
            wep,
            leveling,

        }
        // 캐릭터마다 레벨업을 했을경우가 필요한데 열거형을 통해 판별해서 레벨업을 해줘야하지만 
        // 현재 코드를 작성하면서 고민하게 되는점은 가장 쉬운 레벨업인데 
        // 레벨업에서 
        public enum Character
        {
            Gun,
            Magic,
            Sword,
            Fighter,
            Monster
             
        };
        
        // 레벨업은 생각해야할점은 현재 캐릭터마다 레벨업 하는게 따로 존재한다는점이고 
        // 단독캐릭, 2캐릭 동시 레벨업도 존재하면서
        // 몬스터 같은 레벨업도 처리가 필요하기때문에 초기값에 선언해주는게 좋다고 생각됨 23.10.04 
        public void levelup()
        {
           /*switch (Character)
            {
                case Character.Gun:
                    levelup(); break;
                case Character.Magic:
                    levelup(); break;
                case Character.Sword:
                    levelup(); break;
                case Character.Fighter:
                    levelup(); break;
                case Character.Monster:
                    levelup(); break;

            }*/
           

            this.level += 10; 


        }
        public void levelup_card_effect (int leveling)
        {   // 왜 열거형 
            if (Character.Gun == 0)
            {   
                this.level += 10;
            }else if() 
            {
                this.level += 10;
            }

          //  card_effect.level = 1;
        }

        

      
    }
}
