namespace Parcial_2___Dario_Zubaray
{
    class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public string MostrarInforme(double promedio)
        {
            return $@"Alumno: {NombreCompleto()} (Legajo: {Legajo})
     Promedio general: {promedio:F2}
--------------------------------";
        }
    }
}
