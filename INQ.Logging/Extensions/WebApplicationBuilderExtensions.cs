using INQ.Logging.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Serilog;

namespace INQ.Logging.Extensions;

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
