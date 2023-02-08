using System.Diagnostics;
using INQ.Logging.Extensions;
using Serilog;

namespace INQ.Logging.Console.TestClasses
{
    public static class ProcessLogger
    {
        public static void LogProcesses(ILogger logger)
        {
            var processes = Process.GetProcesses();
            foreach (var p in processes)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    // How ot use 'tabs' for equal spacing!! (...)
                    logger.Log("Title: " + p.MainWindowTitle);
                    logger.Log("Peak Virtual Memory: " + p.PeakVirtualMemorySize64 + "Peak Paged Memory: " + p.PeakPagedMemorySize64);
                }
            }
        }
    }
}
