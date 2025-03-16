using ISW0712_EvalucionI.Interface;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Implementation
{
    internal class LoggerArchivoService: ILoggerSalidaService
    {
        public void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null)
        {
            var mensaje = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {accion} - {entidad}";
            if (id.HasValue)
            {
                mensaje += $": {id.Value}";
            }

            File.AppendAllText("evaluacionI.log", mensaje + Environment.NewLine);
        }
    }
}
