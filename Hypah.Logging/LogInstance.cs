
namespace Hypah.Logging
{
    internal class LogInstance : ILogReceiver
    {
        public static int MaxLogLines { get; set; } = 500;

        private readonly List<LogMessage> _messages = [];
        private readonly List<ILogReceiver> _observers = [];

        private readonly object _lock = new object();

        public void LogMessage(LogMessage message)
        {
            lock (_lock)
            {
                while (_messages.Count > MaxLogLines)
                {
                    _messages.RemoveAt(0);
                }
                foreach (var reciever in _observers)
                {
                    reciever.LogMessage(message);
                }
            }
        }

        public void RegisterReciever(ILogReceiver reciever)
        {
            lock (_lock)
            {
                _observers.Add(reciever);
                foreach (var message in _messages)
                {
                    reciever.LogMessage(message);
                }
            }
        }

        public void RemoveReciever(ILogReceiver reciever)
        {
            lock (_lock)
            {
                _observers.Remove(reciever);
            }
        }
    }
}
