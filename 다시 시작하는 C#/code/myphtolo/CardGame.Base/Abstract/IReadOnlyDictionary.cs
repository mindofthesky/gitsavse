using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Base.Abstract
{
    internal interface IReadOnlyDictionary<Tkey, TValue> : IEnumerable<KeyValuePair<Tkey, TValue>>
    {
        int Count { get; }
        TValue this[Tkey key] { get; } 
        bool ContainsKey(Tkey key);
        bool TryGetValue(Tkey key, out TValue value);
    }
}
