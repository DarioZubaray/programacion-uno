
namespace Punto_2___Dario_Zubaray
{
    class Cola
    {
        public Nodo Inicio;

        public void Encolar(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
            }
        }

        public Nodo BuscarUltimo(Nodo unNodo)
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

        public Nodo Desencolar()
        {
            if (Inicio == null)
            {
                return null;
            }
            else
            {
                Nodo aux = Inicio;
                if (Inicio.Siguiente != null)
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
