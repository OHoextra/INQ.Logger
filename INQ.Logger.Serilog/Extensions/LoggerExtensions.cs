using Serilog;
using Serilog.Events;

namespace Sandbox.Application.Extensions;

public static class LoggerExtensions
{
    private const LogEventLevel DEFAULT_LEVEL = LogEventLevel.Information;
    private const string DEFAULT_PREFIX = "*** ";

    public static void LogPrefixed(
        this ILogger logger,
        string messageTemplate,
        string prefix = DEFAULT_PREFIX,
        LogEventLevel level = DEFAULT_LEVEL,
        params object?[]? propertyValues) 
        => logger.Log(messageTemplate, prefix, level, propertyValues);

    public static void Log(
        this ILogger logger,
        string messageTemplate,
        string prefix = "",
        LogEventLevel level = DEFAULT_LEVEL,
        params object?[]? propertyValues)
    {
        if (!string.IsNullOrWhiteSpace(prefix))
            messageTemplate = prefix + messageTemplate;

        logger.Write(level, messageTemplate, propertyValues);
    }
}
