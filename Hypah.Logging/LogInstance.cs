
namespace Hypah.Logging
{
    internal class LogInstance : ILogReceiver
    {
        public static int MaxLogLines { get; set; } = 500;

        private readonly List<LogMessage> _messages = new List<LogMessage>();
        private readonly List<ILogReceiver> _observers = new List<ILogReceiver>();

        public void LogMessage(LogMessage message)
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

        public void RegisterReciever(ILogReceiver reciever)
        {
            _observers.Add(reciever);
            foreach (var message in _messages)
            {
                reciever.LogMessage(message);
            }
        }

        public void RemoveReciever(ILogReceiver reciever)
        {
            _observers.Remove(reciever);
        }
    }
}
