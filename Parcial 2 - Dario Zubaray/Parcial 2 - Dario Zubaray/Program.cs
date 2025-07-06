using System;
using System.IO;
using System.Linq;

namespace Parcial_2___Dario_Zubaray
{
    class Program
    {
        public const string PROMEDIO_PATH = "promedio_alumnos.dat";

        static void Main(string[] args)
        {
            Console.WriteLine("Programacion I - 2do Parcial – Dario Zubaray");

            Console.Write("\n1) Cargando vectores de alumnos y notas...");
            Alumno[] alumnos = CargarAlumnos();
            Nota[] notas = CargarNotas();
            Console.WriteLine("cargado!\n");

            Console.WriteLine("\n2) Calculando sus promedios...\n");
            CalcularPromedios(alumnos, notas);

            Console.WriteLine("Fin Programa");
            Console.ReadKey();
        }

        static void CalcularPromedios(Alumno[] alumnos, Nota[] notas)
        {
            // Se recorre y agrupa por notas
            var notasOrdenadas = notas.OrderBy(n => n.Legajo).ToArray();
            double mejorPromedio = .0d;
            int legajoMejorPromedio = -1;

            int i = 0;
            while (i < notasOrdenadas.Length)
            {
                // Tomo el legajo de la iteracion en curso
                int legajoActual = notasOrdenadas[i].Legajo;
                int suma = 0;
                int cantidad = 0;

                while (i < notasOrdenadas.Length && notasOrdenadas[i].Legajo == legajoActual)
                {
                    int notaObtenida = notasOrdenadas[i].NotaNumerica;
                    // Se omite los aplazos (solo las notas mayores a 4)
                    if (notaObtenida > 4)
                    {
                        suma += notaObtenida;
                        cantidad++;
                    }
                    i++;
                }

                Alumno alumno = alumnos.FirstOrDefault(a => a.Legajo == legajoActual);

                if (alumno != null)
                {
                    double promedio = (double)suma / cantidad;
                    // Validando por mejor promedio y guardando su legajo
                    if (mejorPromedio < promedio)
                    {
                        mejorPromedio = promedio;
                        legajoMejorPromedio = alumno.Legajo;
                    }

                    Console.WriteLine($"{alumno.MostrarInforme(promedio)}\n");
                    GuardarPromediosEnArchivo(alumno.MostrarInforme(promedio));
                }
            }

            Alumno alumnoAMostrar = alumnos.FirstOrDefault(a => a.Legajo == legajoMejorPromedio);
            string mensajeMejorPromedio = $@"
El mejor promedio({mejorPromedio}) fue registrado por {alumnoAMostrar.NombreCompleto()})
(Legajo: {alumnoAMostrar.Legajo})";
            Console.WriteLine(mensajeMejorPromedio);
            GuardarPromediosEnArchivo(mensajeMejorPromedio);
        }

        static void GuardarPromediosEnArchivo(String informe)
        {
            using (StreamWriter writer = new StreamWriter(PROMEDIO_PATH, append: true))
            {
                writer.WriteLine($"{informe}\n");
            }
        }

        static Alumno[] CargarAlumnos()
        {
            Alumno[] alumnos = 
            {
                new Alumno()
                {
                    Legajo = 1, Apellido = "Zubaray", Nombre = "Dario"
                },
                new Alumno()
                {
                    Legajo = 2, Apellido = "Gonzalez", Nombre = "Lucia"
                },
                new Alumno()
                {
                    Legajo = 3, Apellido = "Martinez", Nombre = "Santiago"
                },
                new Alumno()
                {
                    Legajo = 4, Apellido = "Fernandez", Nombre = "Valentina"
                },
                new Alumno()
                {
                    Legajo = 5, Apellido = "Perez", Nombre = "Juan"
                },
                new Alumno()
                {
                    Legajo = 6, Apellido = "Ramirez", Nombre = "Sofia"
                },
                new Alumno()
                {
                    Legajo = 7, Apellido = "Torres", Nombre = "Mateo"
                },
                new Alumno()
                {
                    Legajo = 8, Apellido = "Lopez", Nombre = "Camila"
                },
                new Alumno()
                {
                    Legajo = 9, Apellido = "Diaz", Nombre = "Nicolas"
                },
                new Alumno()
                {
                    Legajo = 10, Apellido = "Silva", Nombre = "Agustina"
                }
            };
            return alumnos;
        }

        static Nota[] CargarNotas()
        {
            Nota[] notas =
            {
                new Nota() { Legajo = 1, NotaNumerica = 9, NombreDeMateria = "Programacion estructurada", Fecha = new DateTime(2025, 3, 15) },
                new Nota() { Legajo = 1, NotaNumerica = 6, NombreDeMateria = "Sistemas de computacion I", Fecha = new DateTime(2025, 5, 20) },

                new Nota() { Legajo = 2, NotaNumerica = 4, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 3, 10) },
                new Nota() { Legajo = 2, NotaNumerica = 8, NombreDeMateria = "Sistemas de computacion II", Fecha = new DateTime(2025, 6, 12) },

                new Nota() { Legajo = 3, NotaNumerica = 10, NombreDeMateria = "Programacion estructurada", Fecha = new DateTime(2025, 3, 20) },
                new Nota() { Legajo = 3, NotaNumerica = 5, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 4, 5) },

                new Nota() { Legajo = 4, NotaNumerica = 2, NombreDeMateria = "Sistemas de computacion I", Fecha = new DateTime(2025, 4, 10) },
                new Nota() { Legajo = 4, NotaNumerica = 7, NombreDeMateria = "Programacion estructurada", Fecha = new DateTime(2025, 5, 25) },

                new Nota() { Legajo = 5, NotaNumerica = 6, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 4, 30) },
                new Nota() { Legajo = 5, NotaNumerica = 3, NombreDeMateria = "Sistemas de computacion II", Fecha = new DateTime(2025, 6, 5) },

                new Nota() { Legajo = 6, NotaNumerica = 9, NombreDeMateria = "Programacion estructurada", Fecha = new DateTime(2025, 3, 18) },
                new Nota() { Legajo = 6, NotaNumerica = 10, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 5, 10) },

                new Nota() { Legajo = 7, NotaNumerica = 5, NombreDeMateria = "Sistemas de computacion I", Fecha = new DateTime(2025, 4, 15) },
                new Nota() { Legajo = 7, NotaNumerica = 4, NombreDeMateria = "Sistemas de computacion II", Fecha = new DateTime(2025, 6, 20) },

                new Nota() { Legajo = 8, NotaNumerica = 7, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 4, 2) },
                new Nota() { Legajo = 8, NotaNumerica = 8, NombreDeMateria = "Sistemas de computacion II", Fecha = new DateTime(2025, 6, 18) },

                new Nota() { Legajo = 9, NotaNumerica = 3, NombreDeMateria = "Programacion estructurada", Fecha = new DateTime(2025, 3, 22) },
                new Nota() { Legajo = 9, NotaNumerica = 6, NombreDeMateria = "Sistemas de computacion I", Fecha = new DateTime(2025, 5, 17) },

                new Nota() { Legajo = 10, NotaNumerica = 5, NombreDeMateria = "Programacion orientada a objetos", Fecha = new DateTime(2025, 3, 29) },
                new Nota() { Legajo = 10, NotaNumerica = 2, NombreDeMateria = "Sistemas de computacion II", Fecha = new DateTime(2025, 6, 9) }
            };
            return notas;
        }
    }
}
