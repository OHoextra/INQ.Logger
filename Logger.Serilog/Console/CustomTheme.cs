using Serilog.Sinks.SystemConsole.Themes;

namespace Logger.Serilog.Console
{
    public static class AnsiConsoleThemes
    {
        public static AnsiConsoleTheme CustomTheme { get; } = new AnsiConsoleTheme(
            new Dictionary<ConsoleThemeStyle, string>
            {
                /* 
                "\x1b[38;5;1m"      -> Faded Red
                "\x1b[38;5;2m"      -> Faded Green
                "\x1b[38;5;3m"      -> Faded Gold
                "\x1b[38;5;4m"      -> Faded Blue
                "\x1b[38;5;5m"      -> Faded Purple
                "\x1b[38;5;6m"      -> Faded Turquise
                "\x1b[38;5;0001m"   -> Dark Faded Red
                "\x1b[38;5;0002m"   -> Faded Green
                "\x1b[38;5;0003m"   -> Gold
                "\x1b[38;5;0004m"   -> Dark Blue
                "\x1b[38;5;0005m"   -> Purple
                "\x1b[38;5;0006m"   -> Light Faded Blue
                "\x1b[38;5;0007m"   -> Faded White
                "\x1b[38;5;0008m"   -> Gray
                "\x1b[38;5;0009m"   -> Light Red
                "\x1b[38;5;0010m"   -> Green
                "\x1b[38;5;0011m"   -> Light Faded Yellow
                "\x1b[38;5;0012m"   -> Faded Blue
                "\x1b[38;5;0013m"   -> Purple/Pink 
                "\x1b[38;5;0014m"   -> Turquise
                "\x1b[38;5;0015m"   -> White
                "\x1b[38;5;0019m"   -> Dark Faded Blue
                 */

                [ConsoleThemeStyle.LevelVerbose]        = "\x1b[38;5;0008m",
                [ConsoleThemeStyle.LevelDebug]          = "\x1b[38;5;0010m",
                [ConsoleThemeStyle.LevelInformation]    = "\x1b[38;5;0015m",
                [ConsoleThemeStyle.LevelWarning]        = "\x1b[38;5;0003m",
                [ConsoleThemeStyle.LevelError]          = "\x1b[38;5;0009m",
                [ConsoleThemeStyle.LevelFatal]          = "\x1b[38;5;0013m",
                [ConsoleThemeStyle.Text]                = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.SecondaryText]       = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.TertiaryText]        = "\x1b[38;5;0008m",
                [ConsoleThemeStyle.Invalid]             = "\x1b[38;5;0011m",
                [ConsoleThemeStyle.Null]                = "\x1b[38;5;0027m",
                [ConsoleThemeStyle.Name]                = "\x1b[38;5;0007m",
                [ConsoleThemeStyle.String]              = "\x1b[38;5;0045m",
                [ConsoleThemeStyle.Number]              = "\x1b[38;5;0200m",
                [ConsoleThemeStyle.Boolean]             = "\x1b[38;5;0027m",
                [ConsoleThemeStyle.Scalar]              = "\x1b[38;5;0085m",
            });
    }
}

