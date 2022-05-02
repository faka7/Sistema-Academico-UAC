using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    interface Mantenimiento
    {
        string Agregar();
        string Eliminar();
        string Actualizar();
        string Listar();
        string Buscar();
    }
    
}
