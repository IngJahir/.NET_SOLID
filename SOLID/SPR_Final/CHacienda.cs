using System;
using System.Collections.Generic;
using System.Text;

namespace SPR_Final
{
    // Creamos una clase especializada para la otra responsabilidad
    // Ahora cada clase tiene solo una responsabilidad
    class CHacienda
    {
        public static double CalcularImpuesto(CEmpleado pEmpleado) 
        {
            return pEmpleado.Sueldo * 0.35;
        }

        public static void PagarImpuesto(CEmpleado pEmpleado) 
        {
            double imp = CalcularImpuesto(pEmpleado);
            Console.WriteLine("Se paga {0} en impuestos por parte de {1}", imp, pEmpleado);
        }
    }
}
