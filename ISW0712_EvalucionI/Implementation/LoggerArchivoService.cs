using ISW0712_EvalucionI.Interface;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW0712_EvalucionI.Implementation
{
    internal class LoggerArchivoService: ILoggerSalidaService
    {
        public void GenerarLog(string mensaje)
        {
           File.AppendAllText("evaluacionI.log", $"[{DateTime.Now}] {mensaje}");
        }
    }
}
