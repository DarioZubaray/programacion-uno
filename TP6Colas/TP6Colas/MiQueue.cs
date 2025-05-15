using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6Colas
{
    class MiQueue
    {
        public MiNodo Inicio;

        public void Encolar(MiNodo unNodo)
        {
            if(Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                MiNodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
        }

        public MiNodo BuscarUltimo(MiNodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public MiNodo Desencolar()
        {
            if (Inicio == null)
            {
                return null;
            }
            else
            {
                MiNodo aux = Inicio;
                if(Inicio.Siguiente != null)
                {
                    Inicio = Inicio.Siguiente;
                }
                else
                {
                    Inicio = null;
                }

                return aux;
            }
        }
    }
}
