using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public Sexo Sexo { get; set; }
        public Estado Estado { get; set; } = Estado.NoMatriculado;
    }
}
