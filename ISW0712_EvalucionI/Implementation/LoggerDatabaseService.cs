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

namespace ISW0712_EvalucionI.Implementation
{
    internal class LoggerDatabaseService : ILoggerSalidaService
    {
        private readonly AppDbContext _context;

        public LoggerDatabaseService(AppDbContext context)
        {
            _context = context;
        }

        public void GenerarLog(string mensaje)
        {
            AppEventLog eventLog = new AppEventLog
            {
                Message = mensaje,
                Timestamp = DateTime.UtcNow
            };

            _context.EventLogs.Add(eventLog);
            _context.SaveChanges();
        }
    }
}
