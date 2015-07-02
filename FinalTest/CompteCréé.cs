namespace FinalTest
{
    public struct CompteCréé : IEvenementMetier
    {
        private string _numéroDeCompte;
        private int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            this._numéroDeCompte = numéroDeCompte;
            this._autorisationDeCrédit = autorisationDeCrédit;
        }

    }
}