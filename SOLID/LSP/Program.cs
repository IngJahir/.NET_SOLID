using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primera prueba con new
            Noticiero miNoticiero = new Noticiero("Hola a todos");
            miNoticiero.Muestra();

            Radio miRadio = new Radio("Como estan?");
            miRadio.Muestra();

            Console.WriteLine("-------");

            // Sustituimos la clase hija y vemos como se comporta

            Noticiero sustitucion = new Radio("Estamos probando");
            sustitucion.Muestra();

            // Probamos el mismo codigo con la segunda version virtual y override 

        }
    }
}
