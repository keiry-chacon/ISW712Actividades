namespace ISW0712_EvalucionI.Interface
{
    public interface IRegistroLog
    {
        void RegistrarLog(string entidad, string accion, int? id = null);

    }
}
