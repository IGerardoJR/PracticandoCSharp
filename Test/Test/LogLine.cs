
namespace Test
{
    public class LogLine
    {
        string? _message;

        public LogLine() { }

        public LogLine(string message) {
            _message = message;
        }

        public static string Message(string logLine)
        {
            return "";
        }

        // Loglevel
        public static string LogLevel(string logLine)
        {
            throw new NotImplementedException();
        }

        // reformat
        public static string Reformat(string logLine)
        {
            throw new Exception();
        }
    }
}
