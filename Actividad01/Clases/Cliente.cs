using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad01.Clases
{
    public class Cliente : Persona
    {
        public Empresa Empresa { get; set; }

        public Cliente(string nombre, int telefono, Sexo sexo, int edad, Empresa empresa)
            : base(nombre, telefono, sexo, edad)
        {
            Empresa = empresa;
        }

        public override string MostrarInfo()
        {
            return $"Cliente: {Nombre}, Empresa: {Empresa.MostrarInfo()}";
        }
    }

}