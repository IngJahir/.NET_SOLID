using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    class Multiavanzado : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Estoy escaneando tu documento");
        }

        public void Faxear()
        {
            Console.WriteLine("Enviar un fax");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo tu reporte");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
    }
}
