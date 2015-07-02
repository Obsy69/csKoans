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

        public string TexteNombresImpairs
        {
            get { return _keyValuePairs.OrderBy(s => s.Value).Where(s => (s.Value % 2 != 0)).Select(s => s.Key).Aggregate((s, s1) => s + ", " + s1) ; }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return _keyValuePairs.Where(s => (s.Key.Length > 5)).Select(s => s.Key).First(); }
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return _keyValuePairs.OrderBy(s => s.Value).Skip(3).Take(4).Select(s => s.Value); }
        }
    }
}
