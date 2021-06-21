using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Final
{
    class CInventarioAlimento : CBaseInventario
    {
        // base: Le enviamos a la clase base (en este caso CBaseInventario) el pProducto
        public CInventarioAlimento(CProducto pProducto):base(pProducto)
        {
        }

        public override double CalcularProducto()
        {
            producto.Precio *= 1.2;
            return producto.Precio;
        }
    }
}
