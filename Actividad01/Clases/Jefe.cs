using Actividad01.Data.Enum;


namespace Actividad01.Clases
{
    public class Jefe : Empleado
    {
        public string Categoria { get; set; }

        public Jefe(string nombre, int telefono, Sexo sexo, int edad, Direccion direccion, decimal salario, string puesto, Empresa empresa, string categoria)
            : base(nombre, telefono, sexo, edad, direccion, salario, puesto, empresa)
        {
            Categoria = categoria;
        }

        public override string MostrarInfo()
        {
            return $"Jefe: {Nombre}, Categoria: {Categoria}, Empresa: {Empresa.MostrarInfo()}";
        }
    }
}