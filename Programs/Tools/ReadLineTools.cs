namespace app.Programs.Tools;

public class ReadLineTools
{
    public static int GetNumber()
    {
        string? readLine = Console.ReadLine();

        while (string.IsNullOrEmpty(readLine) || !RegexTool.HasOnlyNumbers(readLine))
        {
            // Check exceptions.
            if (string.IsNullOrEmpty(readLine))
            {
                WriteLineTools.LogError("Value can't be null or empty, please try again.");
            }
            else if (!RegexTool.HasOnlyNumbers(readLine))
            {
                WriteLineTools.LogError("Value must contain only digits, please try again.");
            }

            readLine = Console.ReadLine();
        }

        return Int32.Parse(readLine);
    }

    public static bool GetBoolean(string trueStr, string falseStr, bool defaultAnswer)
    {
        string? readLine = Console.ReadLine();
        readLine = String.IsNullOrEmpty(readLine) ? defaultAnswer ? trueStr : falseStr : readLine;

        while (!String.Equals(readLine, trueStr, StringComparison.OrdinalIgnoreCase) && !String.Equals(readLine, falseStr, StringComparison.OrdinalIgnoreCase))
        {
            WriteLineTools.LogError("The answer must be either " + trueStr.ToUpper() + " or " + falseStr.ToUpper() + ", please try again");
            readLine = Console.ReadLine();
        }

        return String.Equals(readLine, trueStr, StringComparison.OrdinalIgnoreCase);
    }
}
