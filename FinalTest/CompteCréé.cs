namespace FinalTest
{
    public struct CompteCréé : IEvénementMétier
    {
        private string _numéroDeCompte;
        private int _autorisationDeCrédit;

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            this._numéroDeCompte = numéroDeCompte;
            this._autorisationDeCrédit = autorisationDeCrédit;
        }

        public string NuméroDeCompte
        {
            get { return _numéroDeCompte; }
        }
    }
}