using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class EstadoAgachado : IEstadoDelPersonaje
    {
        public void ManejarInput(Personaje personaje, Input input)
        {
            if (input.Nombre == "RELEASE_DOWN")
            {                
                personaje.SetearGrafico("PARADO");
                personaje.Estado = new EstadoParado();
            }
            
        }



    
    }
}
