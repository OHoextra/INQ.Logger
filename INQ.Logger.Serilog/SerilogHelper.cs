using INQ.Logger.Serilog.Console;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Debugging;

namespace INQ.Logger.Serilog
{
    public static class SerilogHelper
    {
        private const string DEFAULT_LOG_TEMPLATE = "[{Timestamp:HH:mm:ss}|{Level:u3}|{SourceContext}: {Message:lj} {NewLine}{Exception}";

        private static LoggerConfiguration? _loggerConfig;
        private static bool _hasInitialized;

        private static LoggerConfiguration ConfigureLogger(IConfiguration config)
        {
            if (_loggerConfig == null)
            {
                var baseConfig = new LoggerConfiguration().ReadFrom.Configuration(config);
                baseConfig.MinimumLevel.Information();
                baseConfig.Enrich.FromLogContext();
                baseConfig.WriteTo.Console(outputTemplate: DEFAULT_LOG_TEMPLATE, theme: AnsiConsoleThemes.CustomTheme);

                _loggerConfig = baseConfig;
            }

            return _loggerConfig;
        }

        public static ILogger InitializeLogger(IConfiguration config)
        {
            var logger = ConfigureLogger(config).CreateLogger();

            if (!_hasInitialized)
            {
                SelfLog.Enable(System.Console.Out);
                Log.Logger = logger;

                _hasInitialized = true;
            }

            return logger;
        }
    }
}