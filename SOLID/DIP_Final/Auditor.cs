using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Final
{
    class Auditor
    {
        private IAuditable miAlmacen;
        
        // Ahora el auditor ya no esta fuertemente acoplado con el almacen
        public Auditor(IAuditable pAlmacen)
        {
            miAlmacen = pAlmacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;
            IEnumerable<Producto> listado = miAlmacen.obtenProductos(0);

            foreach (Producto p in listado)
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

