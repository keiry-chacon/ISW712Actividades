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
        public void GenerarLog(string mensaje)
        {   
            Console.WriteLine($"[{DateTime.Now}] {mensaje}");
        }
    }
}
