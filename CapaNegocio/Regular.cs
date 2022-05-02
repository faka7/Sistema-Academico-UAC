using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno
    {
        private int ciclo;
        private int seccion;
        private int sexo;

        public int Ciclo
        {
            get => default;
            set
            {
            }
        }

        public int Seccion
        {
            get => default;
            set
            {
            }
        }

        public int Sexo
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

        public void Convalidar()
        {
            throw new System.NotImplementedException();
        }
    }
}