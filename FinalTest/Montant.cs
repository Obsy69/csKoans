namespace FinalTest
{
    public class Montant
    {
        private int _montantDepot;

        public Montant(int montantDepot)
        {
            _montantDepot = montantDepot;
        }

        public int MontantDepot
        {
            get { return _montantDepot; }
        }
    }
}