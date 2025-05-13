using System.Runtime.CompilerServices;

namespace Hypah.Logging
{
    public class ComponentLogger
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

        public void Write(LogLevel level, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Write(level, _component, msg, methodName, filePath, lineNumber);
        }

        public void Write(string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            Log.Write(_defaultLevel, _component, msg, methodName, filePath, lineNumber);
        }
    }
}
