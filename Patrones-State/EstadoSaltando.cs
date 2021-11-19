using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class EstadoSaltando : IEstadoDelPersonaje
    {

        public void ManejarInput(Personaje personaje, Input input)
        {
            if (input.Nombre == "PRESS_DOWN")
            {
                personaje.SetearGrafico("CAYENDO");
                personaje.Estado = new EstadoTirandose();
            }
        }

     
    }
}
