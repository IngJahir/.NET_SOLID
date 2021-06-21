using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Final
{
    interface IAuditable
    {
        IEnumerable<Producto> obtenProductos(int pTipo);
    }
}
