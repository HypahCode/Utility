using System;
using System.Runtime.CompilerServices;

namespace Hypah.Logging
{
    public interface IComponentLogger
    {
        void Trace(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Debug(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Info(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Warning(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Error(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Error(string component, Exception exception, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Fatal(string component, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Write(LogLevel level, string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
        void Write(string msg, [CallerMemberName] string? methodName = null, [CallerFilePath] string? filePath = null, [CallerLineNumber] int lineNumber = 0);
    }
}
