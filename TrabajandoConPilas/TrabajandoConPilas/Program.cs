using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajandoConPilas
{
    class Program
    {
        static void Main(string[] args)
        {
            MiPila pueblosPila = new MiPila();

            MiNodo puebloOrigen = new MiNodo { Pueblo = "Pueblo Origen" };
            pueblosPila.Apilar(puebloOrigen);
            MostrarRutaEnTope(pueblosPila);

            MiNodo puebloA = new MiNodo { Pueblo = "Pueblo A" };
            pueblosPila.Apilar(puebloA);
            MostrarRutaEnTope(pueblosPila);

            MiNodo puebloB = new MiNodo { Pueblo = "Pueblo B" };
            pueblosPila.Apilar(puebloB);
            MostrarRutaEnTope(pueblosPila);

            MiNodo puebloC = new MiNodo { Pueblo = "Pueblo C" };
            pueblosPila.Apilar(puebloC);
            MostrarRutaEnTope(pueblosPila);

            MiNodo puebloDestino = new MiNodo { Pueblo = "Pueblo Destino" };
            pueblosPila.Apilar(puebloDestino);
            MostrarRutaEnTope(pueblosPila);

            Console.WriteLine("\nIniciando camino de regreso.\n");

            MostrarRutaDesapilando(pueblosPila);
            Console.ReadKey();
        }

        static void MostrarRutaEnTope(MiPila pueblosPila)
        {
            MiNodo puebloNodo = pueblosPila.Tope();
            if (puebloNodo != null)
            {
                Console.WriteLine("Pueblo: " + puebloNodo.Pueblo);
            }
        }

        static void MostrarRutaDesapilando(MiPila pueblosPila)
        {
            MiNodo puebloNodo = pueblosPila.Desapilar();
            if (puebloNodo != null)
            {
                Console.WriteLine("Pueblo: " + puebloNodo.Pueblo);
                MostrarRutaDesapilando(pueblosPila);
            }
            else
            {
                Console.WriteLine("Ha llegado a destino.");
            }
        }
    }
}
