using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona, Mantenimiento
    {
        private string horario;
        private string estadoCivil;
        private string especialidad;
        private string cantHora;

        public string Horario { get => horario; set => horario = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string CantHora { get => cantHora; set => cantHora = value; }

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

        public string Enseñar()
        {
            return "El metodo enseñar no ha sido implementado";
        }
        public string Existir()
        {
            return "El metodo existir no ha sido implementado";
        }

        public string Asistir()
        {
            return "El metodo asistir no ha sido implementado";
        }
    }
}