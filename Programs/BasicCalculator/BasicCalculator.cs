using app.Programs.Tools;

namespace app.Programs.BasicCalculator;

public class BasicCalculator
{
    public BasicCalculator()
    {
        WriteLineTools.LogInfo("Basic calculator instantiated!");
        StartProgram();
    }

    public void StartProgram()
    {
        WriteLineTools.LogInfo("Basic calculator started!");
        WriteLineTools.LogBold("Select the mathematical operation:");
        SelectMathOps();
    }

    private void SelectMathOps()
    {
        Dictionary<string, string> dicMathOps = new() { { "sum", "SumOp" }, { "multiplication", "MultiplicationOp" } };
        for (int i = 0; i < dicMathOps.Count(); i++)
        {
            WriteLineTools.LogUnderline((i + 1) + " - " + dicMathOps.ElementAt(i).Key);
        }

        WriteLineTools.LogBold("\nSelect the operation (enter the corresponding number):");
        int codeOp = ReadLineTools.GetNumber();
        while (codeOp < 1 || codeOp > dicMathOps.Count)
        {
            WriteLineTools.LogError("The selected number does not correspond to any operation.");
            codeOp = ReadLineTools.GetNumber();
        }

        WriteLineTools.LogSucces("The selected operation is: " + dicMathOps.ElementAt(codeOp - 1).Key);

        typeof(MathematicalOps).GetMethod(dicMathOps.ElementAt(codeOp - 1).Value).Invoke(null, null);
    }
}
