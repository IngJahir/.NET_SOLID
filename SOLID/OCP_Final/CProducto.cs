using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Final
{
    class CProducto
    {
        private string nombre;
        private int categoria;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public double Precio { get => precio; set => precio = value; }

        public CProducto(string pNombre, int pCategoria, double pPrecio)
        {
            nombre = pNombre;
            categoria = pCategoria;
            precio = pPrecio;
        }
        public override string ToString()
        {
            return string.Format("El producto {0} cuesta {1}", nombre, precio);
        }
    }
}
