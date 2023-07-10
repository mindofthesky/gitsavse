using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Engine.Abstract
{
    public interface ICardCollectionFactory
    {
        void SetId(Guid id);
        void AddCardProvider(Type providerType, IReadOnlyDictionary<string, string> arguments);

        ICardCollection CardCardCollection();
    }
}
