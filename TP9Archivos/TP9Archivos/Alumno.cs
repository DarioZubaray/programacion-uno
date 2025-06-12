using System;

namespace TP9Archivos
{
    class Alumno
    {
        public string Legajo { get; set; }
        public string ApellidoNombre { get; set; }
        public string Categoria { get; set; }

        public Alumno(){}

        public Alumno(string linea)
        {
            if (string.IsNullOrWhiteSpace(linea))
            {
                throw new ArgumentException("La línea no puede estar vacía", nameof(linea));
            }

            string[] datos = linea.Split(',');

            if (datos.Length < 3)
            {
                throw new FormatException("La línea no tiene el formato esperado");
            }

            this.Legajo = datos[0].Trim();
            this.ApellidoNombre = datos[1].Trim();
            this.Categoria = datos[2].Trim();
        }

        public override string ToString()
        {
            return $"{Legajo}, {ApellidoNombre}, {Categoria}";
        }
    }
}
