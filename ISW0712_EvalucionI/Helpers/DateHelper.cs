namespace ISW0712_EvalucionI.Helpers
{
    public class DateHelper
    {
        public static string FormatearFechaActual(string formato = "yyyy-MM-dd HH:mm:ss")
        {
            return DateTime.UtcNow.ToString(formato);
        }
    }
}
