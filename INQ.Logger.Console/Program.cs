// See https://aka.ms/new-console-template for more information

using INQ.Logger.Application;
using INQ.Logger.Application.Configuration;
using INQ.Logger.Serilog;

namespace INQ.Logger.Console
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            try
            {
                var configuration = ConfigurationHelper.GetConfiguration();
                var logger = SerilogHelper.InitializeLogger(configuration);
                ProcessLogger.LogProcesses(logger);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
