using System.Runtime.CompilerServices;

namespace Hypah.Logging
{
    public class ComponentLogger : IComponentLogger
    {
        private readonly string _component;
        private readonly LogLevel _defaultLevel;

        public ComponentLogger(string component, LogLevel defaultLevel = LogLevel.Debug) 
        {
            _component = component;
            _defaultLevel = defaultLevel;
        }
        
        public ComponentLogger(object component, LogLevel defaultLevel = LogLevel.Debug) 
            : this(component.ToString()!, defaultLevel)
        {
        }

        public void Trace(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Trace(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Debug(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Debug(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Info(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Info(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Warning(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Warning(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Error(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Error(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Error(string component, Exception exception, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Error(component, exception, methodName ?? "", filePath ?? "", lineNumber);
        }
        public void Fatal(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Fatal(component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Write(LogLevel level, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Write(level, _component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }

        public void Write(string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Write(_defaultLevel, _component, msg, methodName ?? "", filePath ?? "", lineNumber);
        }
    }
}
