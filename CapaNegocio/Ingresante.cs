using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Ingresante : Alumno
    {
        private int edad;
        private int horario;
        private int metodoingreso;

        public int Edad
        {
            get => default;
            set
            {
            }
        }

        public int Horario
        {
            get => default;
            set
            {
            }
        }

        public int MetodoIngreso
        {
            get => default;
            set
            {
            }
        }

        public void Aprobar()
        {
            throw new System.NotImplementedException();
        }

        public void Atender()
        {
            throw new System.NotImplementedException();
        }
    }
}