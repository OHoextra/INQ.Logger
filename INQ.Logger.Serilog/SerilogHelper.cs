using Microsoft.Extensions.Configuration;
using Serilog;

namespace INQ.Logger.Serilog
{
    public static class SerilogHelper
    {
        public static ILogger GetLoggerForContext<T>()
        {
            var loggerConfig = ConfigureFromJson();

            return loggerConfig.CreateLogger()
                .ForContext<T>();
        }

        public static void SetStaticLogger()
        {
            var loggerConfig = ConfigureFromJson();
            Log.Logger = loggerConfig.CreateLogger();
        }
        public static ILogger GetLogger()
        {
            var loggerConfig = ConfigureFromJson();

            return loggerConfig.CreateLogger();
        }

        public static LoggerConfiguration ConfigureFromJson()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .Build();

            var loggerConfig = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration);

            return loggerConfig;
        }
    }
}