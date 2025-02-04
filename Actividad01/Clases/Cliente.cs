using Actividad01.Data.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Actividad01.Clases
{
    public class Cliente : Persona
    {
        private Empresa Empresa { get; set; }

        public Cliente(string nombre, int telefono, Sexo sexo, Direccion direccion, Empresa empresa)
       : base(nombre, telefono, sexo, direccion)

        {
            Empresa = empresa;
        }

 
        public override string MostrarInfo()
        {
            return $"Cliente: {Nombre}, Tel: {Telefono}, Sexo: {Sexo}, Direccion: {Direccion.MostrarDireccion()},  {Empresa.MostrarInfo()}";

        }


    }

}