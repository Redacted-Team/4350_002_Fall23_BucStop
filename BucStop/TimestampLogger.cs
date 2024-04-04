namespace BucStop
{
    using Microsoft.Extensions.Logging;
    using System;

    public class TimestampLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true; // You may implement filtering based on log level
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {formatter(state, exception)}";

            Console.WriteLine(message); // Change this to your preferred logging mechanism
        }
    }
}
