using System;

namespace ISP
{
    class program
    {
        static void Main(string[] arg)
        {
            Multiavanzado avanzado = new Multiavanzado();
            avanzado.Escanear();
            avanzado.Faxear();
            avanzado.Imprimir();
            avanzado.Telefono();

            Console.WriteLine("--------");

            Fax miFax = new Fax();
            miFax.Telefono();
            miFax.Faxear();
            miFax.Imprimir();

            Console.WriteLine("--------");

            Multisencillo sencillo = new Multisencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
            //sencillo.Telefono();  // Lanzara excepcion
        }
    }

}
