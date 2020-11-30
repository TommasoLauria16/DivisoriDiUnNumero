using System;
using Gestione;

namespace provacalcolocomputazionale
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Divisore.LeggiNumero();
            Divisore.StampaDivisori(n);

        }
    }
}
