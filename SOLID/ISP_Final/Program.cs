using System;

namespace ISP_Final
{
    class Program
    {
        static void Main(string[] args)
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
           
            Console.WriteLine("--------");

            Multisencillo sencillo = new Multisencillo();
            sencillo.Escanear();
            sencillo.Imprimir();
        }
    }
}
