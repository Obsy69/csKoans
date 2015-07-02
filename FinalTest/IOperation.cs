using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest
{
    public interface IOperation
    {
        int Calculer(string p);
        bool PeutCalculer(string p);
    }
}