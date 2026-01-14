
namespace Hypah.Logging
{
    internal class LogDispatcher : ILogDispatcher
    {
        private readonly List<ILogReceiver> _receivers = new List<ILogReceiver>();

        public int MaxHistorySize { get; set; } = 1000;
        public bool IsEnabled { get; set; } = true;

        private readonly Queue<LogMessage> _history = new();
        private readonly Lock _lock = new Lock();

        public void LogMessage(LogMessage message)
        {
            if (!IsEnabled) return;
            lock (_lock)
            {
                _history.Enqueue(message);
                if (_history.Count > MaxHistorySize)
                {
                    _history.Dequeue();
                }

                foreach (var receiver in _receivers)
                {
                    if (message.Level >= receiver.MinLevel)
                    {
                        receiver.LogMessage(message);
                    }
                }
            }
        }

        public void RegisterReciever(ILogReceiver logReceiver)
        {
            lock (_lock)
            {
                _receivers.Add(logReceiver);

                foreach (var message in _history)
                {
                    if (message.Level >= logReceiver.MinLevel)
                    {
                        logReceiver.LogMessage(message);
                    }
                }
            }
        }

        public void RemoveReciever(ILogReceiver logReceiver)
        {
            lock (_lock)
            {
                _receivers.Remove(logReceiver);
            }
        }
    }
}