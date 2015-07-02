using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;
        
        public Nombres(List<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public Nombres(IEnumerable<KeyValuePair<string, int>> otherKeyValuePairs)
        {
            _keyValuePairs = otherKeyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return _keyValuePairs.Select(s => s.Value).Where(s => (s % 2 == 0)); }
        }
    }
}
