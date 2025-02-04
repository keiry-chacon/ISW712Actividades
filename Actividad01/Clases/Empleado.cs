using Actividad01.Clases;
using Actividad01.Data.Enum;
using Actividad01.Data.Interface;
public class Empleado : Persona, IEmpleado
{
    protected decimal Salario { get; set; }
    protected string Puesto { get; set; }
    protected Empresa Empresa { get; set; }
    public Empleado(string nombre, int telefono, Sexo sexo,  Direccion direccion, decimal salario, string puesto, Empresa empresa)
        : base(nombre, telefono, sexo, direccion)
    {
        Salario = salario;
        Puesto = puesto;
        Empresa = empresa;
    }

 
    public int CalcularEdad(DateTime fechaNacimiento)
    {
        int edad = DateTime.Now.Year - fechaNacimiento.Year;
        if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            edad--; 
        return edad;
    }

    public string ObtenerPuesto()
    {
        return Puesto;
    }

    public override string MostrarInfo()
    {
        return $"Empleado: {Nombre}, Teléfono: {Telefono}, Sexo: {Sexo}, Puesto: {Puesto}, Salario: {Salario}";
    }
}
