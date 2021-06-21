using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Final
{
    class CInventarioMedicamento:CBaseInventario
    {
        // base: Le enviamos a la clase base (en este caso CBaseInventario) el pProducto
        public CInventarioMedicamento(CProducto pProducto):base(pProducto)
        {
        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
