﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    class Noticiero
    {
        protected string mensaje;
        
        public Noticiero(string pMensaje)
        {
            mensaje = pMensaje;
        }

        // Para primera prueba
        //public void Muestra() 
        //{
        //    Console.WriteLine("Desde el noticiero {0}", mensaje);
        //}

        // Para segunda prueba
        public virtual void Muestra()
        {
            Console.WriteLine("Desde el noticiero {0}", mensaje);
        }
    }
}
