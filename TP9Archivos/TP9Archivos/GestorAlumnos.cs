using System.Collections.Generic;
using System.IO;

namespace TP9Archivos
{
    class GestorAlumnos
    {
        const string archivo = "alumnos.dat";

        public void Alta(Alumno unAlumno)
        {
            using (StreamWriter writer = new StreamWriter(archivo, true))
            {
                writer.WriteLine(unAlumno.ToString());
            }
        }

        public void Baja(string Legajo)
        {
            List<string> lineasFiltradas = new List<string>();

            using (StreamReader reader = new StreamReader(archivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    if (unAlumno.Legajo != Legajo)
                    {
                        lineasFiltradas.Add(linea);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(archivo, false))
            {
                foreach (string linea in lineasFiltradas)
                {
                    writer.WriteLine(linea);
                }
            }
        }

        public void Modificar(string legajoSeleccionado, Alumno alumnoActualizado)
        {
            List<string> lineasModificadas = new List<string>();

            using (StreamReader reader = new StreamReader(archivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Alumno unAlumno = new Alumno(linea);

                    if (unAlumno.Legajo == legajoSeleccionado)
                    {
                        lineasModificadas.Add(alumnoActualizado.ToString());
                    }
                    else
                    {
                        lineasModificadas.Add(linea);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(archivo, false))
            {
                foreach (string linea in lineasModificadas)
                {
                    writer.WriteLine(linea);
                }
            }
        }

        public List<Alumno> Listar()
        {
            List<Alumno> lista = new List<Alumno>();

            using (StreamReader reader = new StreamReader(archivo))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    lista.Add(new Alumno(linea));
                }
            }

            return lista;
        }
    }
}
