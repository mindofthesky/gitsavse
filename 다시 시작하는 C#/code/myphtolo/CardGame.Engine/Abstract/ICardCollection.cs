using CardGame.Engine.CardDefinitions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    internal interface ICardCollection
    {
        Guid id { get; }
        IEquatable<ICardDefinition> Card {  get; }
    }
}
