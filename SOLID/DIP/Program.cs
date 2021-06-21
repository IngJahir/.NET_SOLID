using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            Almacen miAlmacen = new Almacen();
            double total = 0;

            // 0 alimento, 1 medicima, 2 ropa
            miAlmacen.AdicionaProducto(new Producto("Tomate", 0, 15.50));
            miAlmacen.AdicionaProducto(new Producto("Banana", 0, 30));
            miAlmacen.AdicionaProducto(new Producto("Analgesico", 1, 23.80));
            miAlmacen.AdicionaProducto(new Producto("Jeans", 2, 450.99));
            miAlmacen.AdicionaProducto(new Producto("Manzana", 0, 12.38));
            miAlmacen.AdicionaProducto(new Producto("Antiacido", 1, 38.50));

            Console.WriteLine("-----");

            Auditor miAuditor = new Auditor(miAlmacen);
            total = miAuditor.totalesAlimentos();

            Console.WriteLine("El total de alimentos es {0}",total);
        }
    }
}
