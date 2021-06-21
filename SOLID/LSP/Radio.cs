using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    class Radio : Noticiero
    {
        public Radio(string pMensaje):base(pMensaje)
        {
        }

        // Para la primera prueba
        //public new void Muestra() 
        //{
        //    Console.WriteLine("Desde el radio {0}", mensaje);
        //}

        public override void Muestra()
        {
            Console.WriteLine("Desde el radio {0}",mensaje);
        }
                
    }
}
