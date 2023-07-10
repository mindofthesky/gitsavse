using CardGame.Engine.CardDefinitions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    internal interface ICardGameEnvoirment
    {
        private readonly List<ICardCollection> _collections;
        private readonly List<ICardDefinition> _definitions;
        private readonly List<IDeck> _decks;
        IEnumerable<ICardCollection> Collections { get { return _collections; } }
        IEnumerable<ICardDefinition> Defintions { get { return _definitions; } }
        IEnumerable<IDeck> Decks { get { return _decks; } }

        ICardDefinition GetCardDefintion(Guid collectionId, Guid cardId);
    }
}
