using System.Text.RegularExpressions;

namespace app.Programs.Tools;

public class RegexTool
{
    public static bool HasOnlyNumbers(string str)
    {
        return Regex.IsMatch(str, @"^\d+$");
    }
}
