using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    // Clase de alto nivel
    // -------------------
    class Auditor
    {
        private Almacen miAlmacen;

        public Auditor(Almacen pAlmacen)
        {
            miAlmacen = pAlmacen;
        }

        public double totalesAlimentos() 
        {
            double total = 0;
            foreach (Producto p in miAlmacen.Inventario) 
            {
                if (p.Tipo == 0) 
                {
                    Console.WriteLine(p);
                    total += p.Costo;
                }                
            }

            return total;
        }
    }
}
