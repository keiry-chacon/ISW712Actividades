using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    internal class Empresa
    {
        private string Nombre { get; set; }

        public Empresa(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string MostrarInfo()
        {
            return $"Empresa: {Nombre}";
        }
    }
}
