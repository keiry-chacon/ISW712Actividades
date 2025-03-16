using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW0712_EvalucionI.Implementation
{
    internal class LoggerPantallaService: ILoggerSalidaService
    {
        public void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null)
        {
            try
            {
                var mensaje = $"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] {accion} - {entidad}";

                if (id.HasValue)
                {
                    mensaje += $": {id.Value}";
                }

                Console.WriteLine(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en la consola: {ex.Message}");
            }
        }
    }
}
