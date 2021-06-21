using System;
using System.Collections.Generic;
using System.Text;

namespace LSP_Final
{
    class Noticiero : Principal
    {
        public Noticiero(string pMensaje) : base(pMensaje) 
        {
        }

        public override void Muestra()
        {
            Console.WriteLine("Desde el noticiero: {0}", mensaje);
        }
    }
}
