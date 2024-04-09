namespace BucStop
{
    using Microsoft.Extensions.Logging;
    using System;

    // This class details the beginning steps of the logger with timestamps. It implements ILogger,
    // which comes with a few methods to be fulfilled.

    // This was written via ChatGPT 3.5.
    public class TimestampLogger : ILogger
    {
        // This method is called when a new scope is requested for logging. 
        // Scopes are used to provide additional contextual information for log messages.
        // In this implementation, it simply returns null because no specific scope is being managed.
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        // This method is called to check if logging at the specified log level is enabled.
        // It can be used to implement filtering based on log levels.
        // In this implementation, it always returns true, indicating that logging at any level is enabled.
        // You may modify this method to implement filtering based on log levels if needed.
        public bool IsEnabled(LogLevel logLevel)
        {
            return true; // You may implement filtering based on log level
        }

        // This method is called to perform the actual logging of a message.
        // It formats the log message with a timestamp in the format "yyyy-MM-dd HH:mm:ss",
        // combines it with the formatted state and exception provided by the formatter function,
        // and writes the resulting message to the console.
        // You can replace Console.WriteLine(message) with your preferred logging mechanism.
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {formatter(state, exception)}";

            Console.WriteLine(message); // Change this to your preferred logging mechanism
        }
    }
}
