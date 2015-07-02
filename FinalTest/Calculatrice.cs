using System;

namespace FinalTest
{
    public class Calculatrice
    {
        private readonly IOperation[] _listeOperations;

        public Calculatrice(IOperation[] listeOperations)
        {
            _listeOperations = listeOperations;
        }

        public int Calculer(string p)
        {
            foreach (var listeOperation in _listeOperations)
            {
                if (listeOperation.PeutCalculer(p))
                {
                    return listeOperation.Calculer(p);
                }
            }

            return 0;
        }
    }
}
