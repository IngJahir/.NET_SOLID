using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    // Clase de bajo nivel
    // -------------------
    class Almacen
    {
        private List<Producto> inventario;
        
        // Nos vemos forzados a crear la propiedad para que se pueda contar el inventario
        // Al ser una propiedad de tipo List forzamos a auditor a trabajar con List
        public List<Producto> Inventario { get => inventario; set => inventario = value; }

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto pProducto) 
        {
            inventario.Add(pProducto);
            Console.WriteLine("Adicionamos {0}",pProducto.Nombre);
        }
    }
}
