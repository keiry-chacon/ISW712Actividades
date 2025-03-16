using ISW0712_EvalucionI.Models;

namespace ISW0712_EvalucionI.Interface
{
    public interface IEventLog()
    {
        void Log(ActionLog accion, EntityLog entidad, int? id = null);

    }