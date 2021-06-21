using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Final
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string pMensaje)
        {
            mensaje = pMensaje;
        }

        // Lo creamos como metodo abstracto para que cada version lo implemente
        public abstract void Muestra();
    }
}
