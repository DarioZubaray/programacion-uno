
namespace TrabajandoConPilas
{
    class MiPila
    {
        MiNodo _tope;

        public MiNodo Tope()
        {
            return _tope;
        }

        public void Apilar(MiNodo unNodo)
        {
            if (_tope == null)
            {
                _tope = unNodo;
            }
            else
            {
                MiNodo auxiliar = _tope;
                _tope = unNodo;
                _tope.Siguiente = auxiliar;
            }
        }

        public MiNodo Desapilar()
        {
            MiNodo aux = null;
            if (_tope != null)
            {
                aux = _tope;

                _tope = _tope.Siguiente;
            }
            return aux;
        }
    }
}
