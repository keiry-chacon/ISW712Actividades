using Actividad01.Data.Enum;
using Actividad01.Data.Interface;
using Actividad01.Clases;
namespace Actividad01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear direcciones
            Direccion direccion1 = new Direccion("San José", "Desamparados", "Centro", "Frente al parque");
            Direccion direccion2 = new Direccion("Alajuela", "San Ramón", "Centro", "Cerca del hospital");
            Direccion direccion3 = new Direccion("Heredia", "San Pablo", "Centro", "Frente a la iglesia");

            // Crear 3 empresas de forma normal
            Empresa empresa1 = new Empresa("Tienda El Sol");
            Empresa empresa2 = new Empresa("TechSolutions");
            Empresa empresa3 = new Empresa("Constructora Atlas");

            // Crear clientes y asociarlos con empresas diferentes
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente("Dayron", 85736521, Sexo.Hombre, direccion1, empresa1),
                new Cliente("María", 85478963, Sexo.Mujer, direccion2, empresa2),
                new Cliente("Carlos", 89987412, Sexo.Hombre, direccion3, empresa3)
            };

            // Mostrar información de los clientes
            Console.WriteLine("\n===========================");
            Console.WriteLine("Información de Clientes:");
            Console.WriteLine("===========================");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.MostrarInfo());
            }

            // Crear empleados
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado("Jaz", 89933211, Sexo.Mujer,  direccion1, 2500.50m, "Desarrolladora", empresa1),
                new Empleado("Luis", 87765432, Sexo.Hombre, direccion2, 2200.75m, "Analista", empresa2),
                new Empleado("Ana", 88812345, Sexo.Mujer,  direccion3, 2700.90m, "Diseñadora", empresa3)
            };

            // Mostrar información de los empleados
            Console.WriteLine("\n===========================");
            Console.WriteLine("Información de Empleados:");
            Console.WriteLine("===========================");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.MostrarInfo());
            }

            // Crear jefe
            Jefe jefe1 = new Jefe("Carlos", 99988877, Sexo.Hombre, direccion1, 5000.00m, "Gerente General", empresa1, "Alta");

            // Mostrar la información del jefe
            Console.WriteLine("\n===========================");
            Console.WriteLine("Información del Jefe:");
            Console.WriteLine("===========================");
            Console.WriteLine(jefe1.MostrarInfo());


            // Mostrar el total de personas

            Console.WriteLine("\n===========================");
            Console.WriteLine($"Total de personas: {Persona.TotalPersonas}");
            Console.WriteLine("===========================");

        }

        static void MostrarDatosEmpleado(IEmpleado empleado)
        {
            Console.WriteLine($"Edad Calculada: {empleado.CalcularEdad(new DateTime(1994, 5, 20))}");
            Console.WriteLine($"Puesto: {empleado.ObtenerPuesto()}");
        }

    }
}
    
