using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Final
{
    class Almacen : IAuditable
    {
        // Ya no hay necesidad de dar acceso a la lista        
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto pProducto)
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}", pProducto.Nombre);
        }
        
        // Implementacion de la interfaz, hacemos la busqueda flexible
        public IEnumerable<Producto> obtenProductos(int pTipo)
        {
            List<Producto> encontrados = new List<Producto>();
            foreach (Producto p in inventario) 
            {
                if (p.Tipo == pTipo)
                    encontrados.Add(p);
            }

            return encontrados;          
        }
    }
}
