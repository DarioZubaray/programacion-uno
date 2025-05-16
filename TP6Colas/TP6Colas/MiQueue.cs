
namespace TP6Colas
{
    class MiQueue
    {
        public MiNodo Fin;

        public void Encolar(MiNodo unNodo)
        {
            if(Fin == null)
            {
                Fin = unNodo;
            }
            else
            {
                MiNodo aux = Fin;
                unNodo.Anterior = aux;
                Fin = unNodo;
            }
        }

        public MiNodo Desencolar()
        {
            if (Fin == null)
            {
                return null;
            }
            else
            {
                MiNodo aux = Fin;
                if(Fin.Anterior!= null)
                {
                    Fin = Fin.Anterior;
                }
                else
                {
                    Fin = null;
                }

                return aux;
            }
        }
    }
}
