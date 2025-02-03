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

        protected static int TotalPersonas;

        public Persona(
            string nombre, int telefono, Sexo sexo, int edad)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Sexo = sexo;
            this.Edad = edad;
            TotalPersonas++;
        }
        public void AgregarDireccion(string provincia, string canton, string distrito, string otrasSenas)
        {
            Direccion = new Direccion(provincia, canton, distrito, otrasSenas);
        }

        public abstract string MostrarInfo();

    }
}