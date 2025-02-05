using Actividad01.Data.Enum;


namespace Actividad01.Clases
{
    public class Jefe : Empleado
    {
        private string Categoria { get; set; }

        public Jefe(string nombre, int telefono, Sexo sexo, Direccion direccion, decimal salario, string puesto, Empresa empresa, string categoria) : base(nombre, telefono, sexo, direccion, salario, puesto, empresa)
        {
            Categoria = categoria;
        }


        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}, Categoría: {Categoria}";
        }
    }
}