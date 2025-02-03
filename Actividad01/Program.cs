using Actividad01.Data.Enum;
using Actividad01.Data.Interface;
using Actividad01.Clases;
namespace Actividad01
{
    internal class Program
    {
        static void Main(string[] args)
        {
       

            // Crear una dirección
            Direccion direccion = new Direccion("San José", "Desamparados", "Centro", "Frente al parque");
            Console.WriteLine("Dirección creada:");
            Console.WriteLine(direccion.MostrarDireccion());

            // Crear un cliente
            Empresa empresaCliente = new Empresa("Tienda El Sol");
            Cliente cliente = new Cliente("Dayron", 85736521, Sexo.Hombre, direccion, empresaCliente);
            Console.WriteLine("\nInformación del Cliente:");
            Console.WriteLine(cliente.MostrarInfo());

            // Crear un empleado
            Empresa empresaEmpleado = new Empresa("TechSolutions");
            Empleado empleado = new Empleado("Jaz", 89933211, Sexo.Mujer, 30, direccion, 2500.50m, "Desarrolladora", empresaEmpleado);
            Console.WriteLine("\nInformación del Empleado:");
            Console.WriteLine(empleado.MostrarInfo());

            // Crear un jefe
            Jefe jefe = new Jefe("Sofía", 88991122, Sexo.Mujer, 40, direccion, 5500.75m, "Gerente General", empresaEmpleado, "Alta Gerencia");
            Console.WriteLine("\nInformación del Jefe:");
            Console.WriteLine(jefe.MostrarInfo());

            // Pruebas con interfaz
            Console.WriteLine("\nDatos del Empleado desde la Interfaz:");
            MostrarDatosEmpleado(empleado);
        }

        static void MostrarDatosEmpleado(IEmpleado empleado)
        {
            Console.WriteLine($"Edad Calculada: {empleado.CalcularEdad(new DateTime(1994, 5, 20))}");
            Console.WriteLine($"Puesto: {empleado.ObtenerPuesto()}");
        }

    }
}
    
