
using System.ComponentModel;

namespace TrabajandoConListas
{
    class ListaPacientes
    {
        public PacienteNodo Inicio;

        public PacienteNodo BuscarUltimo(PacienteNodo unNodo)
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

        public void AgregarAlFinal(PacienteNodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                PacienteNodo aux = BuscarUltimo(Inicio);
                aux.Siguiente = unNodo;
                unNodo.Anterior = aux; // Enlazar el nuevo nodo con el anterior
            }
        }

        public void AgregarAlPrincipio(PacienteNodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                PacienteNodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
                aux.Anterior = Inicio; // Enlazar el nodo anterior
            }
        }

        public PacienteNodo GetByCodigo(string codigo)
        {
            if (Inicio == null)
            {
                return null;
            }

            if(Inicio.Dato.Codigo == codigo)
            {
                return Inicio;
            }
            else
            {
                if(Inicio.Siguiente == null)
                {
                    return null;
                }
                else
                {
                    return BuscarCodigo(Inicio.Siguiente, codigo);
                }
                
            }
        }

        private PacienteNodo BuscarCodigo(PacienteNodo unNodo, string codigo)
        {
            if (unNodo.Dato.Codigo == codigo)
            {
                return unNodo;
            }
            else
            {
                return BuscarCodigo(unNodo.Siguiente, codigo);
            }
        }

        public BindingList<Paciente> GetAsList()
        {
            BindingList<Paciente> pacienteDataSource = new BindingList<Paciente>();

            PacienteNodo pacienteNodo = Copiar();
            if (pacienteNodo.Dato != null)
            {
                pacienteDataSource.Add(pacienteNodo.Dato);
                while (pacienteNodo.Siguiente != null)
                {
                    pacienteDataSource.Add(pacienteNodo.Siguiente.Dato);
                    pacienteNodo.Siguiente = pacienteNodo.Siguiente.Siguiente;
                }
            }
            return pacienteDataSource;
        }

        public PacienteNodo Copiar()
        {
            return new PacienteNodo
            {
                Dato = this.Inicio.Dato,
                Siguiente = this.Inicio.Siguiente
            };
        }

        public void BorrarByCodigo(string codigo)
        {
            if (Inicio.Dato.Codigo == codigo)
            {
                Inicio = Inicio.Siguiente;
            }
            else
            {
                PacienteNodo pacienteBorrar = BuscarCodigo(Inicio.Siguiente, codigo);
                pacienteBorrar.Anterior = pacienteBorrar.Siguiente;
            }
        }

    }
}
