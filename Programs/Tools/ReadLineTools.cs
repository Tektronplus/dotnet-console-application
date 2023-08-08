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
}
