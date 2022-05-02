using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrativo : Persona, Mantenimiento
    {
        private string cargo;
        private string sueldo;
        private string horario;
        private string tipoContrato;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Sueldo { get => sueldo; set => sueldo = value; }
        public string Horario { get => horario; set => horario = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }

        public string Actualizar()
        {
            return "El metodo actualizar no ha sido implementado";
        }

        public string Agregar()
        {
            return "El metodo agregar no ha sido implementado";
        }

        public String Buscar()
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

        public string Gestionar()
        {
            return "El metodo gestionar no ha sido implementado";
        }

        public string Elaborar()
        {
            return "El metodo elaborar no ha sido implementado";
        }
    }
}