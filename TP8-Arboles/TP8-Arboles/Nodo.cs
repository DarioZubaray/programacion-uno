
namespace TP8_Arboles
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(string valor)
        {
            Valor = valor;
            Izquierda = null;
            Derecha = null;
        }
    }
}
