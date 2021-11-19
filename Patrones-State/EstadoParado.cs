using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class EstadoParado : IEstadoDelPersonaje
    {
        public void ManejarInput(Personaje personaje, Input input)
        {
            if (input.Nombre == "PRESS_DOWN")
            {
                personaje.SetearGrafico("AGACHADO");
                personaje.Estado = new EstadoAgachado();
            }
            else if(input.Nombre == "PRESS_UP")
            {
                personaje.SetearGrafico("SALTANDO");
                personaje.Estado = new EstadoSaltando();
            }
        }
    }
}
