


namespace ISW0712_EvalucionI.Implementation
{
    public class DatabaseEventService : IEventLog
    {

        private readonly AppDbContext _context;
        public DatabaseEventLog(AppDbContext context)
        {
            _context = _context;
        }
        public void Log(ActionLog accion, EntityLog entidad, int? id = null)
        {
            var eventLog = new AppEventLog
            {
                Accion = accion,
                Entidad = entidad,
                EntidadId = id,
                Timestamp = DateTime.UtcNow
            };

            _context.EventLogs.Add(eventLog);
            _context.SaveChanges();
        }
    }
}