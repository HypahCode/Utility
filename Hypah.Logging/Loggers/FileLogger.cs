
namespace Hypah.Logging.Loggers
{
    internal class FileLogger : ILogReceiver
    {
        private string _fileName;
        private string? _directory;
        private bool _autoCreateNewFiles = false;
        private DateTime _creationDate;
        private readonly object _lock = new object();

        public LogLevel MinLevel { get; set; } = LogLevel.Trace;

        public static FileLogger CreateOnEmptyFile(string fileName)
        {
            File.Create(fileName);
            return new FileLogger(fileName);
        }

        public static FileLogger AppendToFile(string fileName)
        {
            return new FileLogger(fileName);
        }

        public static FileLogger AutoCreate(string path)
        {
            var filename = CreateNewFileName(path);
            var fileLogger = new FileLogger(filename);
            fileLogger._directory = path;
            fileLogger._autoCreateNewFiles = true;
            return fileLogger;
        }

        private FileLogger(string filename)
        {
            _fileName = filename;
            _creationDate = DateTime.Now.Date;
        }

        public void LogMessage(LogMessage message)
        {
            lock (_lock)
            {
                if (_autoCreateNewFiles && !string.IsNullOrEmpty(_directory))
                {
                    if (_creationDate.Date != message.TimeStamp.Date)
                    {
                        _fileName = CreateNewFileName(_directory);
                        _creationDate = DateTime.Now.Date;
                    }
                }

                var line = $"{message.TimeStamp}\t{message.Level}\t{message.Component}\t{message.Method}\t{message.Filename}\t{message.LineNumber}\t{message.Message}";
                File.AppendAllLines(_fileName, [line]);
            }
        }

        private static string CreateNewFileName(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var newFileName = Path.Combine(directory, DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
            return newFileName;
        }
    }
}
