using System;
using System.Collections.Generic;
using System.Text;

namespace SPR
{
    class Program
    {
        static void Main(string[] arg) 
        {
            CEmpleado empleado = new CEmpleado("Juan","Programador",23,18000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
        }
    }
}
