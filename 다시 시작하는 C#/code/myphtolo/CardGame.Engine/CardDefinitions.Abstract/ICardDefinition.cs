using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.CardDefinitions.Abstract
{
    internal interface ICardDefinition
    {
        Guid id { get; }
        string Name {  get; }
        Color Color { get; }
        ValueObject.CardType cardType { get; }
        string SubType { get; }
        ValueObject.Castingcost castingcost { get; }
        string FlavorText { get; }
        string Artist {  get; }
        string Set {  get; }



    }
}
