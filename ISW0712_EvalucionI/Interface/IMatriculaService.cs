using ISW0712_EvalucionI.Models;

namespace ISW0712_EvalucionI.Interface
{
    public interface IMatriculaService
    {
        IEnumerable<Matricula> GetAll();
        Matricula FindById(int id);
        void Create(Matricula matricula);
        void Edit(Matricula matricula);
        void Delete(int id);
    }
}
