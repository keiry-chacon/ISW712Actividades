using ISW0712_EvalucionI.Interface;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Models;
using static System.Collections.Specialized.BitVector32;
using ISW0712_EvalucionI.Enum;

namespace ISW0712_EvalucionI.Implementation
{
    internal class LoggerDatabaseService : ILoggerSalidaService
    {
        private readonly AppDbContext _context;
        private readonly IEventLog _eventLog;

        public LoggerDatabaseService(AppDbContext context,IEventLog eventLog)
        {
            _context = context;
            _eventLog = eventLog;
        }

        public void GenerarLog(ActionLog accion, EntityLog entidad, int? id = null)
        {
            _context.EventLogs.Add(_eventLog.Log(accion, entidad, id));
            _context.SaveChanges();
        }
    }
}
