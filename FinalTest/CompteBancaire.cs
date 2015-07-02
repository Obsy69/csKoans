using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FinalTest
{
    public class CompteBancaire
    {
        private string _numéroDeCompte;
        private int _autorisationDeCrédit;
        private Montant _montantDepot;
        private DateTime _dateDepot;

        public CompteBancaire(CompteCréé compteCréé)
        {
            _numéroDeCompte = compteCréé.NuméroDeCompte;
        }

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            _numéroDeCompte = compteCréé.NuméroDeCompte;
            _montantDepot = dépotRéalisé.MontantDepot;
            _dateDepot = dépotRéalisé.DateDepot;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            var nouveauCompte = new CompteCréé(numéroDeCompte,autorisationDeCrédit);

            yield return nouveauCompte;
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            var nouveauDepot = new DépotRéalisé(_numéroDeCompte, montantDepot, dateDepot);

            yield return nouveauDepot;
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            var nouveauRetrait = new RetraitRéalisé(_numéroDeCompte, montantRetrait, dateRetrait);

            yield return nouveauRetrait;
        }
    }

}