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
        public void GenerarLog(string mensaje)
        {
            _loggerService.GenerarLog(mensaje);
        }
    }
}
