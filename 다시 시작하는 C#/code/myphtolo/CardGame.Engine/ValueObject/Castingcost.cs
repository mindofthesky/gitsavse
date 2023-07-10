using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.ValueObject
{
    public class Castingcost
    { 
        public IReadOnlyDictionary<ICardCo,int> ValueCost { get;private set; }
        public int SkilyCost { get; private set; }
        public int MonsterCost { get; private set; }
        public int ArmorCost { get; private set; }
        public int ValuesCost { get; private set; }
        public int WephoneCost { get; private set; }
        public int levelCost { get; private set; }

        public int handCost { get; private set; }
        public Castingcost(int Skill = 0 , int Monster = 0, int Armor = 0, int ValuesC = 0, int Wephone = 0, int level = 0, int hand) 
        {
            SkilyCost = Skill;
            MonsterCost = Monster;
            ArmorCost = Armor;
            ValuesCost = ValuesC;
            WephoneCost = Wephone;
            levelCost = level;
            handCost = hand;

            ICardCo = new ReadonlyDictionary<ICardCo,int>(new Dictionary<ICardCo, int>
            {
                
                {ICardCo.level, levelCost },
                {ICardCo.hand, handCost },
                {ICardCo.skil,SkilyCost },
                {ICardCo.Armor,ArmorCost},
                {ICardCo.Wephone,WephoneCost},
                {ICardCo.Values,ValuesCost},
                {ICardCo.Monster,MonsterCost}
            });

        }

        // 코스트가 필요한 코드를 작성하는 경우 이런 예시를 포함할것
        static void Mosterh()
        {   // 몬스터 카드를 코스트로 하는경우 1 , 핸드를 하는경우 핸드 1 hand 라는 변수도 따로있음 
            //var cost = new Castingcost(Monster:0);
        }

    }
}
