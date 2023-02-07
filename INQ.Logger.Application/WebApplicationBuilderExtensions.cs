namespace INQ.Logger.Application;

public static class WebApplicationBuilderExtensions
{
    public static void UseSerilog(this WebApplicationBuilder appBuilder)
    {
        var logger = LoggingHelper.InitializeLogger(appBuilder.Configuration);

        appBuilder.Logging.ClearProviders();
        appBuilder.Logging.AddSerilog(logger);
        appBuilder.Host.UseSerilog(logger);
    }
}
