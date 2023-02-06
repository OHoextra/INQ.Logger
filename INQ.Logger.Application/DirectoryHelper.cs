namespace INQ.Logger.Application;

public static class DirectoryHelper
{
    public static string CurrentDirectory()
        => Directory.GetCurrentDirectory();

    public static string AppDomainDirectory()
        => AppDomain.CurrentDomain.BaseDirectory;
}
