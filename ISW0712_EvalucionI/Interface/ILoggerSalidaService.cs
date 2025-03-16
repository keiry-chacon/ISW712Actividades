using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Interface
{
    public interface ILoggerSalidaService
    {
        void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null);

    }
}
