using System.ComponentModel.DataAnnotations;

namespace ISW0712_EvalucionI.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante ?Estudiante { get; set; }
    }
}
