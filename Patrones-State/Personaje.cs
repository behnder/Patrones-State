using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_State
{
    class Personaje
    {
        public IEstadoDelPersonaje Estado { get; set; } = new EstadoParado();
        public string Grafico { get; set; }
        public void TransicionDeEstado(Input input)
        {
            Estado.ManejarInput(this, input);
         
        }
  
        public void SetearGrafico(string grafico)
        {
            Grafico = grafico;
        }

        public void MostrarEstadoActual()
        {
            Console.WriteLine("El personaje está: " + Grafico);
        }
    }
}
