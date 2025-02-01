using Actividad01.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad01.Clases
{
    internal class Empleado : Persona
    {
        public decimal Salario { get; set; }
        public string Puesto { get; set; }
        public Empresa Empresa { get; set; }
        public Empleado(string nombre, int telefono, Sexo sexo, int edad) : base(nombre, telefono, sexo, edad)
        {
        }

        public override string MostrarInfo()
        {
            return $"Empleado: {Nombre}, Puesto: {Puesto}, Salario: {Salario}, Empresa: {Empresa.MostrarInfo()}";
        }
    }
}
