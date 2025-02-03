using Actividad01.Data.Enum;

namespace Actividad01.Clases
{
    public class Cliente : Persona
    {
        public Empresa Empresa { get; set; }

        public Cliente(string nombre, int telefono, Sexo sexo, Empresa empresa)
            : base(nombre, telefono, sexo)
       
        {
            Empresa = empresa;
        }

       

        public override string MostrarInfo()
        {
            return $"Cliente: {Nombre}, Empresa: {Empresa.MostrarInfo()}";
        }


    }

}