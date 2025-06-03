using System.Collections.Generic;

namespace TP8_Arboles
{
    public class ArbolBinario
    {
        public Nodo Raiz { get; set; }

        public ArbolBinario()
        {
            Raiz = null;
        }

        public void PreOrden(Nodo unNodo, List<string> recorrido)
        {
            if (unNodo == null) return;
            recorrido.Add(unNodo.Valor);
            PreOrden(unNodo.Izquierda, recorrido);
            PreOrden(unNodo.Derecha, recorrido);
        }

        public void InOrden(Nodo unNodo, List<string> recorrido)
        {
            if (unNodo == null) return;
            InOrden(unNodo.Izquierda, recorrido);
            recorrido.Add(unNodo.Valor);
            InOrden(unNodo.Derecha, recorrido);
        }

        public void PostOrden(Nodo unNodo, List<string> recorrido)
        {
            if (unNodo == null) return;
            PostOrden(unNodo.Izquierda, recorrido);
            PostOrden(unNodo.Derecha, recorrido);
            recorrido.Add(unNodo.Valor);
        }

        public Nodo Buscar(Nodo unNodo, string valor)
        {
            if (unNodo == null) return null;
            if (unNodo.Valor == valor) return unNodo;

            var izq = Buscar(unNodo.Izquierda, valor);
            if (izq != null) return izq;

            return Buscar(unNodo.Derecha, valor);
        }
    }
}
