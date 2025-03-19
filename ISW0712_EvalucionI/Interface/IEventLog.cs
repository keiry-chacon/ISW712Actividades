using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Models;
using System.Diagnostics;

namespace ISW0712_EvalucionI.Interface
{
    public interface IEventLog
    {
        AppEventLog Log(ActionLog accion, EntityLog entidad, int? id = null);

    }
}