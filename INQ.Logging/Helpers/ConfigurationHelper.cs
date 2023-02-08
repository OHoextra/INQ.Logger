using Microsoft.Extensions.Configuration;

namespace INQ.Logging.Helpers;

public static class ConfigurationHelper
{
    private const string JSON_SETTINGS_FILE_NAME = "appsettings";
    private const string JSON_SETTINGS_FILE_EXTENSION = ".json";

    public static IConfiguration GetConfiguration(string envName = "")
    {
        if (string.IsNullOrWhiteSpace(envName))
            envName = EnvironmentHelper.GetEnvironment();

        var configBuilder = new ConfigurationBuilder();

        configBuilder.AddEnvironmentVariables();

        var basePath = DirectoryHelper.AppDomainDirectory();
        configBuilder.SetBasePath(basePath);

        bool configFileExists = false;

        var settingsFileName = $"{JSON_SETTINGS_FILE_NAME}{JSON_SETTINGS_FILE_EXTENSION}";
        var fileName2 = $"{JSON_SETTINGS_FILE_NAME}.{envName}{JSON_SETTINGS_FILE_EXTENSION}";

        var file1Path = Path.Combine(basePath, settingsFileName);
        var file2Path = Path.Combine(basePath, fileName2);

        if (File.Exists(file1Path))
        {
            configBuilder.AddJsonFile(settingsFileName);
            configFileExists = true;
        }
        if (File.Exists(file2Path))
        {
            configBuilder.AddJsonFile(fileName2);
            configFileExists = true;
        }

        if (!configFileExists)
            throw new InvalidOperationException($"No appsettings.json found in base path: '{basePath}'");


        return configBuilder.Build();
    }
}

