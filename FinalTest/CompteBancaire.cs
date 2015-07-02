using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace FinalTest
{
    public class CompteBancaire
    {
        private static string _numéroDeCompte;
        private static int _autorisationDeCrédit;

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            _numéroDeCompte = numéroDeCompte;
            _autorisationDeCrédit = autorisationDeCrédit;

            var nouveauCompte = new CompteCréé(_numéroDeCompte,_autorisationDeCrédit);

            yield return nouveauCompte;
        }
    }

}