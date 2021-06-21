using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Final
{
    class Multisencillo : IMultibasico
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }        
    }
}
