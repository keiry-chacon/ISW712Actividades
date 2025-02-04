using Actividad01.Data.Enum;
using System;


namespace Actividad01.Clases
{
    public abstract class Persona
    {
        // se cambio a protected ya que al mostrar la infor en cliente y empleado no se podia obtener la informacion
        protected string Nombre { get; set; }
        protected int Telefono { get; set; }
        protected Sexo Sexo { get; set; }
        protected int Edad { get; set; }
        protected Direccion Direccion { get; set; }

        private static int TotalPersonas;

        public Persona(string nombre, int telefono, Sexo sexo, int edad, Direccion direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Sexo = sexo;
            Edad = edad;
            Direccion = direccion;
            TotalPersonas++;
        }

        public void AgregarDireccion(string provincia, string canton, string distrito, string otrasSenas)
        {
            Direccion = new Direccion(provincia, canton, distrito, otrasSenas);
            this.Direccion = Direccion;
        }
       //esta private para poder obtenerlo
        public static int ObtenerTotalPersonas()
        {
            return TotalPersonas;
        }
        public abstract string MostrarInfo();

    }
}