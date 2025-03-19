


using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Models;
using System.Diagnostics;

namespace ISW0712_EvalucionI.Implementation
{
    public class DatabaseEventService : IEventLog
    {
        public AppEventLog Log(ActionLog accion, EntityLog entidad, int? id = null)
        {
            var eventLog = new AppEventLog
            {
                Accion    = accion,
                Entidad   = entidad,
                EntidadId = id,
                Timestamp = DateTime.UtcNow
            };
            return eventLog;
        }
    }
}