using System;

namespace FinalTest
{
    public class Multiplication : IOperation
    {
        public bool PeutCalculer(string p)
        {
            if (p.Contains("*"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Calculer(string p)
        {
            int s = 0;
            string[] produit;

            if (PeutCalculer(p))
            {
                produit = p.Split('*');
                s = Int32.Parse(produit[1])*Int32.Parse(produit[0]);
            }

            return s;
        }
    }
}
