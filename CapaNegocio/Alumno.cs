using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno : Persona

    {
        private string seguro;
        private string escuela;
        private string condicion;

        public string Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Condicion { get => condicion; set => condicion = value; }

        public string Estudiar()
        {
            return "El metodo estudiar no ha sido implementado";
        }

        public string Actualizar()
        {
            return "El metodo actualizar no ha sido implementado";
        }

        public string Agregar()
        {
            return "El metodo agregar no ha sido implementado";
        }

        public string Buscar()
        {
            return "El metodo buscar no ha sido implementado";
        }

        public string Eliminar()
        {
            return "El metodo eliminar no ha sido implementado";
        }

        public string Listar()
        {
            return "El metodo listar no ha sido implementado";
        }

        public string Asistir()
        {
            return "El metodo asistir no ha sido implementado";
        }

        public string Existir()
        {
            
                return "El metodo existir no ha sido implementado";
            
        }
    }
}
