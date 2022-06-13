using INQ.Logger.Serilog;
using System.Diagnostics;

namespace INQ.Logger.Application
{
    public static class ProcessLogger
    {
        public static void LogProcesses()
        {
            var logger = SerilogHelper.GetLogger();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    // How ot use 'tabs' for equal spacing!! (...)
                    logger.Information("Title: " + p.MainWindowTitle);
                    logger.Information("Peak Virtual Memory: " + p.PeakVirtualMemorySize64 + "Peak Paged Memory: " + p.PeakPagedMemorySize64);
                }
            }
        }
    }
}
