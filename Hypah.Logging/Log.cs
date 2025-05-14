using Hypah.Logging.Loggers;
using System.Runtime.CompilerServices;

namespace Hypah.Logging
{
    public static class Log
    {
        private static LogInstance? _instance;
        private static LogInstance Instance 
        { 
            get
            {
                if (_instance == null)
                {
                    _instance = new LogInstance();
                    Write(LogLevel.Debug, nameof(Log), MessageOfTheDay.GetMessage());
                }
                return _instance;
            }
        }

        public static void Trace(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Trace, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));

        }

        public static void Debug(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Debug, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Info(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Info, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Warning(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Warn, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Error(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Error, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Fatal(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(LogLevel.Fatal, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Write(LogLevel level, string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(level, component, methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void Write(LogLevel level, object? component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Instance.LogMessage(new LogMessage(level, component?.ToString() ?? "", methodName ?? "", filePath ?? "", lineNumber, msg, DateTime.Now));
        }

        public static void RegisterLogReceiver(ILogReceiver logReceiver)
        {
            Instance.RegisterReciever(logReceiver);
        }

        public static void RemoveLogReceiver(ILogReceiver logReceiver)
        {
            Instance.RemoveReciever(logReceiver);
        }

        public static void AddFileLogger(string filename, bool createNew = false)
        {
            if (createNew)
            {
                Instance.RegisterReciever(FileLogger.CreateOnEmptyFile(filename));
            }
            else
            {
                Instance.RegisterReciever(FileLogger.AppendToFile(filename));
            }
        }

        public static void AddLogFiles(string directory)
        {
            Instance.RegisterReciever(FileLogger.AutoCreate(directory));
        }

        public static void AddConsoleLogger()
        {
            Instance.RegisterReciever(new ConsoleLogger());
        }
    }
}
