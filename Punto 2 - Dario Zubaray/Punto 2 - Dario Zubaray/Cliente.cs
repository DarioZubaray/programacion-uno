
namespace Punto_2___Dario_Zubaray
{
    class Cliente
    {
        public string Codigo { get; set; }
        public decimal Importe { get; set; }
        public bool EsSocio { get; set; }

        public override string ToString()
        {
            return $"Codigo: {Codigo}, Importe: {Importe}, EsSocio: {EsSocio}";
        }
    }
}
