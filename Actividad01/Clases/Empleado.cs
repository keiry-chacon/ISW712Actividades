using Actividad01.Clases;
using Actividad01.Data.Enum;
using Actividad01.Data.Interface;
public class Empleado : Persona, IEmpleado
{
    public decimal Salario { get; set; }
    public string Puesto { get; set; }
    public Empresa Empresa { get; set; }
    public Empleado(string nombre, int telefono, Sexo sexo, int edad, decimal salario, string puesto, Empresa empresa)
        : base(nombre, telefono, sexo, edad)
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
        return $"Empleado: {Nombre}, Puesto: {Puesto}, Salario: {Salario}, Empresa: {Empresa.MostrarInfo()}";
    }
}
