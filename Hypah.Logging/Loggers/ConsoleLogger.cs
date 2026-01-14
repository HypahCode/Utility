namespace Hypah.Logging.Loggers
{
    internal class ConsoleLogger : ILogReceiver
    {
        public LogLevel MinLevel { get; set; } = LogLevel.Trace;

        public ConsoleLogger(LogLevel minLevel = LogLevel.Info)
        {
            MinLevel = minLevel;
        }

        public void LogMessage(LogMessage message)
        {
            string timeStamp = message.TimeStamp.ToString("HH:mm");

            string levelText = message.Level.ToString() ?? string.Empty;
            char levelChar = levelText.Length > 0 ? levelText[0] : '?';

            bool isError = levelChar == 'E' ||
                           levelChar == 'F' ||
                           levelChar == 'C' ||
                           levelText.Equals("Fatal", StringComparison.OrdinalIgnoreCase) ||
                           levelText.Equals("Critical", StringComparison.OrdinalIgnoreCase);

            string methodPart = isError ? (message.Method ?? string.Empty) + "\t" : string.Empty;
            string filePart = isError ? (message.Filename ?? string.Empty) + "\t" + message.LineNumber + "\t" : string.Empty;

            Console.WriteLine($"{timeStamp}\t{levelChar}\t{message.Component ?? string.Empty}\t{methodPart}{filePart}{message.Message}");
        }
    }
}
