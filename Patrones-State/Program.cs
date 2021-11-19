using System;

namespace Patrones_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje celeste = new Personaje();
          
            Console.WriteLine("presionando abajo ");
            celeste.TransicionDeEstado(new Input("PRESS_DOWN"));
            celeste.MostrarEstadoActual();
            Console.WriteLine("presionando abajo de nuevo");
            celeste.TransicionDeEstado(new Input("PRESS_DOWN"));
            Console.WriteLine("soltando abajo");
            celeste.TransicionDeEstado(new Input("RELEASE_DOWN"));
            celeste.MostrarEstadoActual();
            Console.WriteLine("presionando arriba");
            celeste.TransicionDeEstado(new Input("PRESS_UP"));
            celeste.MostrarEstadoActual();
            Console.WriteLine("presionando abajo ");
            celeste.TransicionDeEstado(new Input("PRESS_DOWN"));
            celeste.MostrarEstadoActual();
            Console.WriteLine("presionando arriba");
            celeste.TransicionDeEstado(new Input("PRESS_UP"));
            celeste.MostrarEstadoActual();
                     celeste.MostrarEstadoActual();
            Console.ReadKey();
        }
    }
}
