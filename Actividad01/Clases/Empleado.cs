using Actividad01.Clases;
using Actividad01.Data.Enum;
using Actividad01.Data.Interface;
public class Empleado : Persona, IEmpleado
{
    // se paso a protected ya que sino jefe no tenia acceso a salario
    protected decimal Salario { get; set; }
    private string Puesto { get; set; }
    protected Empresa Empresa { get; set; }
    public Empleado(string nombre, int telefono, Sexo sexo,  Direccion direccion, decimal salario, string puesto, Empresa empresa)
        : base(nombre, telefono, sexo, 1, direccion)
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
        // se quemo una fecha solo para demostracion
        DateTime fecha = new DateTime(1990, 5, 20);
        return $"- {Nombre}, Teléfono: {Telefono}, Sexo: {Sexo}, Edad: {CalcularEdad(fecha)}, Puesto: {ObtenerPuesto()}, Salario: {Salario}, {Empresa.MostrarInfo()}";
    }
}
