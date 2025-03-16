using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Interface;

namespace ISW0712_EvalucionI.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILoggerSalidaService _loggerService;
        public LoggerService(ILoggerSalidaService loggerService)
        {
            _loggerService = loggerService;
        }
        public void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null)
        {
            _loggerService.GenerarLog( accion, entidad, id);
        }
    }
}
