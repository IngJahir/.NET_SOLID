using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Multisencillo : IMultifuncional
    {
        // Necesitamos estos metodos
        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu documento");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }

        // Estos metodos no los necesitamos
        // Si no colocamos implementacion hay que poner excepcion
        public void Faxear()
        {
            throw new NotImplementedException();
        }       

        public void Telefono()
        {
            throw new NotImplementedException();
        }
    }
}
