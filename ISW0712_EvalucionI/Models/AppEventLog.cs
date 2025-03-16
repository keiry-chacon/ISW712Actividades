using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Models
{
    public class AppEventLog
    {

        public int Id { get; set; }
        public ActionLog Accion { get; set; }
        public EntityLog Entidad { get; set; } 
        public int? EntidadId { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
