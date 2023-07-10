using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Base
{
    
    internal class ReadonlyDictionary<Tkey, TValue> : IReadOnlyDictionary<Tkey, TValue>
    {

        private readonly IDictionary<Tkey, TValue> _values;
        public int Count { get { return _values.Count; } }
        public TValue this[Tkey key] { get { return _values[key]; } }
        public ReadonlyDictionary(IDictionary<Tkey, TValue> values)
        {
            _values = values.ToDictionary(k => k.Key, v => v.Value);
        }

        public IEnumerator<KeyValuePair<Tkey,TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ContainKey(Tkey key) { return _values.ContainsKey(key); }

        public bool TryGetValue(Tkey key, out TValue value) { return _values.TryGetValue(key, out value); }
    }
}
