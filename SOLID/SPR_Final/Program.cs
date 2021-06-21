using System;

namespace SPR_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado empleado = new CEmpleado("Juan", "Programador", 23, 180000);
            Console.WriteLine(empleado);
            Console.WriteLine(CHacienda.CalcularImpuesto(empleado));
            CHacienda.PagarImpuesto(empleado);            
        }
    }
}
