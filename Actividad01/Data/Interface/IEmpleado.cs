using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Data.Interface
{
    public interface IEmpleado
    {
        int CalcularEdad(DateTime fechaNacimiento);
        string ObtenerPuesto();
    }

}
