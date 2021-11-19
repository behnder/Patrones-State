using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class Input
    {
        public string Nombre { get;private set; }
        public Input(string nombre)
        {
            Nombre = nombre;
        }
    }
}
