using Actividad01.Data.Enum;
using System;


namespace Actividad01.Clases
{
    public abstract class Persona
    {
        protected string Nombre { get; set; }
        protected int Telefono { get; set; }
        protected Sexo Sexo { get; set; }
        protected int Edad { get; set; }
        protected Direccion Direccion { get; set; }
        public static int TotalPersonas;

        protected Persona(string nombre, int telefono, Sexo sexo, Direccion direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Sexo = sexo;
            Direccion = direccion;
            TotalPersonas++;
        }

        public void AgregarDireccion(string provincia, string canton, string distrito, string otrasSenas)
        {
            Direccion = new Direccion(provincia, canton, distrito, otrasSenas);
            this.Direccion = Direccion;
        }

        public abstract string MostrarInfo();

    }
}