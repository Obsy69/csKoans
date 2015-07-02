using System;

namespace FinalTest
{
    public struct DépotRéalisé : IEvenementMetier
    {
        private string _numéroDeCompte;
        private Montant _montantDepot;
        private DateTime _dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantDepot = montantDepot;
            _dateDepot = dateDepot;
        }

        public string NuméroDeCompte
        {
            get { return _numéroDeCompte; }
        }

        public Montant MontantDepot
        {
            get { return _montantDepot; }
        }

        public DateTime DateDepot
        {
            get { return _dateDepot; }
        }
    }
}