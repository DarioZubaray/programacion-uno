namespace ProgramacionUno
{
    internal class Producto
    {

        public int CodigoProducto {get;set;}
        public int MontoVenta { get; set; }

        public Producto(int codigoProducto, int montoVenta)
        {
            CodigoProducto = codigoProducto;
            MontoVenta = montoVenta;
        }

        public override string ToString()
        {
            return $"  Codigo: {CodigoProducto}, Monto: {MontoVenta}";
        }
    }
}
