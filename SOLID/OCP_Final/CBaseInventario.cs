using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Final
{
    abstract class CBaseInventario
    {
        protected CProducto producto;

        public CProducto Producto { get => producto; set => producto = value; }

        public CBaseInventario(CProducto pProducto)
        {
            producto = pProducto;
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
