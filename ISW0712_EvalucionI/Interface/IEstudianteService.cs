using ISW0712_EvalucionI.Models;

namespace ISW0712_EvalucionI.Interface
{
    public interface IEstudianteService
    {
        IEnumerable<Estudiante> GetAll();
        Estudiante FindById(int id);
        void Create(Estudiante estudiante);
        void Edit(Estudiante estudiante);
        void Delete(int id);
    }
}
