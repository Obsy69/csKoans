using System;

namespace FinalTest
{
    public struct BalanceNégativeDétectée : IEvénementMétier
    {
        private string _numéroDeCompte;
        private Montant _montant;
        private DateTime _dateRetrait;

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montant = montant;
            _dateRetrait = dateRetrait;
        }


    }
}