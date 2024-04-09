namespace BucStop {
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using static IServiceCollection;

    // This was written via ChatGPT 3.5.

    public static class TimestampLoggerExtensions
    {
        // This extension method is used to extend the functionality of the ILoggingBuilder interface.
        // It adds the capability to configure the logging system to include a timestamp in log messages.
        // The method adds a timestamp logger to the logging builder.

        public static ILoggingBuilder AddTimestampLogger(this ILoggingBuilder builder)
        {
            // Inside the method, it accesses the IServiceCollection provided by the logging builder (builder.Services).
            // It registers the TimestampLoggerProvider as a singleton service for ILoggerProvider.
            // This ensures that the TimestampLoggerProvider will be used to create logger instances.
            builder.Services.AddSingleton<ILoggerProvider, TimestampLoggerProvider>();

            // Finally, it returns the logging builder instance to support method chaining.
            // This allows further configuration to be chained after adding the timestamp logger.
            return builder;
        }
    }
}
