﻿using INQ.Logging.Console.TestClasses;

namespace INQ.Logging.Console;

public class Program
{

    static void Main(string[] args)
    {
        try
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            var logger = LoggingHelper.InitializeLogger(configuration);
            ProcessLogger.LogProcesses(logger);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
