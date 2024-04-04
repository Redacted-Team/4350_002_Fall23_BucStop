namespace BucStop
{
    using Microsoft.Extensions.Logging;
    using System;

    public class TimestampLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new TimestampLogger();
        }

        public void Dispose() { }
    }
}
