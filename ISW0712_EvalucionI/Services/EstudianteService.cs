using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Enum;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Models;

namespace ISW0712_EvalucionI.Services
{
    public class EstudianteService : IEstudianteService
    {
        private readonly AppDbContext _context;
        private readonly ILoggerService _loggerService;

        public EstudianteService(AppDbContext context, ILoggerService loggerService)
        {
            _context = context;
            _loggerService = loggerService;

        }
        public IEnumerable<Estudiante> GetAll()
        {
            _loggerService.GenerarLog("GET");
            return _context.Estudiantes.OrderBy(e => e.Id).ToList();

        }

        public Estudiante FindById(int id)
        {
            _loggerService.GenerarLog("GET");
            return _context.Estudiantes.Find(id);

        }

        public void Create(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            _context.SaveChanges();
            _loggerService.GenerarLog("POST");

        }

        public void Edit(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            _context.SaveChanges();
            _loggerService.GenerarLog("PUT");

        }

        public void Delete(int id)
        {
            var estudiante = _context.Estudiantes.Find(id);
            if (estudiante != null && estudiante.Estado != Estado.Matriculado)
            {
                _context.Estudiantes.Remove(estudiante);
                _context.SaveChanges();
                _loggerService.GenerarLog("DELETE");

            }
            else
            {
                throw new InvalidOperationException("No se puede eliminar un estudiante matriculado.");
            }
        }
    }

}
