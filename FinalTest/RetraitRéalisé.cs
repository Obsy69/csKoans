using System;

namespace FinalTest
{
    public struct RetraitRéalisé : IEvénementMétier
    {
        private string _numéroDeCompte;
        private Montant _montantRetrait;
        private DateTime _dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            _numéroDeCompte = numéroDeCompte;
            _montantRetrait = montantRetrait;
            _dateRetrait = dateRetrait;
        }
    }
}