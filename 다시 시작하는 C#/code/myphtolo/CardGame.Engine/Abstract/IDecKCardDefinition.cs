using CardGame.Engine.CardDefinitions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    internal interface IDecKCardDefinition
    {
        int Count { get; }
        ICardDefinition Definition { get; }
    }
}
