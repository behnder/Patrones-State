using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    interface IEstadoDelPersonaje
    {
        void ManejarInput(Personaje personaje, Input input);
      

    }
}
