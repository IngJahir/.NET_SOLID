using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_Final
{
    class Fax : IFax
    {
        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }

        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

       
    }
}
