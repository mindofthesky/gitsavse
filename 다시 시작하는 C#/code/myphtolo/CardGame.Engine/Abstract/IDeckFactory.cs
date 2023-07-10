using CardGame.Engine.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    internal interface IDeckFactory
    {
        void SetId(Guid id);
        void SetDetail(DeckDetails details);
        void AddCard(Guid collectionId, Guid cardId, int count = 1);
        IDeck CreateDeck();
    }
}
