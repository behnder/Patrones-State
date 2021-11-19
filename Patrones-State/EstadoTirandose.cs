using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class EstadoTirandose : IEstadoDelPersonaje
    {
        public void ManejarInput(Personaje personaje, Input input)
        {
           
                personaje.SetearGrafico("PARADO");
                personaje.Estado = new EstadoParado();
            
        }

    
    }
}
