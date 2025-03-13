using ISW0712_EvalucionI.Data;
using ISW0712_EvalucionI.Interface;
using ISW0712_EvalucionI.Models;
using Microsoft.EntityFrameworkCore;

namespace ISW0712_EvalucionI.Services
{
    public class MatriculaService : IMatriculaService
    {
        private readonly AppDbContext _context;
        private readonly ILoggerService _loggerService;

        public MatriculaService(AppDbContext context, ILoggerService loggerService)
        {
            _context = context;
            _loggerService = loggerService;
        }

        public IEnumerable<Matricula> GetAll()
        {
            return _context.Matriculas.Include(m => m.Estudiante).OrderBy(m => m.Id).ToList();
        }

        public Matricula FindById(int id)
        {
            return _context.Matriculas.Include(m => m.Estudiante).FirstOrDefault(m => m.Id == id);
        }

        public void Create(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            _context.SaveChanges();

        }

        public void Edit(Matricula matricula)
        {
            _context.Matriculas.Update(matricula);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var matricula = _context.Matriculas.Find(id);
            if (matricula != null)
            {
                _context.Matriculas.Remove(matricula);
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("No se pudo encontrar la matrícula.");
            }
        }
    }

}
