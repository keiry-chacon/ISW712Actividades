using Actividad01.Data.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad01.Clases
{
    public class Cliente : Persona
    {
        private Empresa Empresa { get; set; }

        public Cliente(string nombre, int telefono, Sexo sexo, Direccion direccion, Empresa empresa)
            : base(nombre, telefono, sexo, 1, direccion)
        {
            Empresa = empresa;
        }


        public override string MostrarInfo()
        {
            return $"- {Nombre}, Tel: {Telefono}, Sexo: {Sexo}, " +
                          $"Dirección: {Direccion.MostrarDireccion()}, {Empresa.MostrarInfo()}";
        }
    }

}