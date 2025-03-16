using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Interface
{
    public interface ILoggerService
    {
        void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null);

    }
}
