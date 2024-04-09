namespace BucStop
{
    using Microsoft.Extensions.Logging;
    using System;

    // This was written via ChatGPT 3.5.

    // This class creates the baseline for the LoggerProvider. It implements ILoggerProvider,
    // which simply just needs to create a logger and return it, whilst disposing of any extras.
    public class TimestampLoggerProvider : ILoggerProvider
    {
        // This method is called when a logger is requested for a specific category.
        // It creates and returns a new instance of the TimestampLogger class.
        // Each logger provider can be associated with one or more logger instances.
        // In this case, it always returns a new instance of TimestampLogger for any requested category.

        public ILogger CreateLogger(string categoryName)
        {
            // Creates and returns a new instance of TimestampLogger.
            return new TimestampLogger();
        }

        // This method is called to release any resources used by the logger provider.
        // Since this implementation does not hold any resources that need to be released explicitly,
        // this method doesn't perform any action.
        public void Dispose() { }
    }
}
