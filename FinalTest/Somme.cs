using System;

namespace FinalTest
{
    public class Somme : IOperation
    {
        public bool PeutCalculer(string p)
        {
            if (p.Contains("+"))
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
            string[] somme;

            if (PeutCalculer(p))
            {
                somme = p.Split('+');
                s = Int32.Parse(somme[1]) + Int32.Parse(somme[0]);
            }

            return s;
        }
    }
}
