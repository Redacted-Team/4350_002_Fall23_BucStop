namespace BucStop
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using static IServiceCollection;

    public static class TimestampLoggerExtensions
    {
        public static ILoggingBuilder AddTimestampLogger(this ILoggingBuilder builder)
        {
            
            builder.Services.AddSingleton<ILoggerProvider, TimestampLoggerProvider>();
            return builder;
        }
    }
}
