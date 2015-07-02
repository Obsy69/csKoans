using System.Runtime.CompilerServices;

namespace FinalTest
{
    public class TypeReference
    {
        private int _valeur;

        public TypeReference (int valeur)
        {
            _valeur = valeur;
        }

        public override bool Equals(object obj)
        {
            return this._valeur == ((TypeReference)obj)._valeur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}