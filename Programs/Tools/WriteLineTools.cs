namespace app.Programs.Tools;

public class WriteLineTools
{
    public static void LogInfo(string info)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\x1b[3mInfo: " + info + "\x1b[0m");
        Console.ResetColor();
    }

    public static void LogSucces(string success)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\x1b[1mSuccess: " + success + "\x1b[0m");
        Console.ResetColor();
    }
    public static void LogError(string error = "error")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\x1b[1mError: " + error + "\x1b[0m");
        Console.ResetColor();
    }

    // Style logs
    public static void LogBold(string log)
    {
        Console.WriteLine("\x1b[1m" + log + "\x1b[0m");
    }

    // Special logs
    public static void LogQuestion(string question)
    {
        Console.WriteLine("\x1b[1m\x1b[3m" + question + "\x1b[0m");
    }
}
