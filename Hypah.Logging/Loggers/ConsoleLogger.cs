
namespace Hypah.Logging.Loggers
{
    internal class ConsoleLogger : ILogReceiver
    {
        public void LogMessage(LogMessage message)
        {
            Console.WriteLine(message);
        }
    }
}
