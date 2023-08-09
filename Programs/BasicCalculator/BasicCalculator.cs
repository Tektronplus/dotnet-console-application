using app.Programs.Tools;

namespace app.Programs.BasicCalculator;

public class BasicCalculator
{
    public BasicCalculator()
    {
        WriteLineTools.LogInfo("Basic calculator instantiated!");
        StartProgram();
        do
        {
            SelectMathOps();

        } while (AskAnotherCal());
        WriteLineTools.LogInfo("Basic calculator finished!");
    }

    public void StartProgram()
    {
        DisplayTitle();
        WriteLineTools.LogInfo("Basic calculator started!");
    }

    private static void SelectMathOps()
    {
        Dictionary<string, string> dicMathOps = new() { { "Sum", "SumOp" }, { "Multiplication", "MultiplicationOp" }, { "Subtraction", "SubtractionOp" }, { "Division", "DivisionOp" } };
        for (int i = 0; i < dicMathOps.Count(); i++)
        {
            WriteLineTools.LogUnderline((i + 1) + " - " + dicMathOps.ElementAt(i).Key);
        }

        WriteLineTools.LogBold("\nSelect the mathematical operation (enter the corresponding number):");
        int codeOp = ReadLineTools.GetNumber();
        while (codeOp < 1 || codeOp > dicMathOps.Count)
        {
            WriteLineTools.LogError("The selected number does not correspond to any operation.");
            codeOp = ReadLineTools.GetNumber();
        }

        WriteLineTools.LogSuccess("The selected operation is " + (dicMathOps.ElementAt(codeOp - 1).Key).ToUpper());

        //typeof(MathematicalOps).GetMethod(dicMathOps.ElementAt(codeOp - 1).Value).Invoke(null, null);
        var methodName = dicMathOps.ElementAt(codeOp - 1).Value;
        var methodInfo = typeof(MathematicalOps).GetMethod(methodName);

        if (methodInfo != null)
        {
            // Verifica se il metodo è statico
            if (methodInfo.IsStatic)
            {
                // Se il metodo è statico, passa null come oggetto target
                methodInfo.Invoke(null, null);
            }
            else
            {
                // Se il metodo non è statico, crea un'istanza dell'oggetto e chiamalo su quell'istanza
                var mathOpsInstance = new MathematicalOps();
                methodInfo.Invoke(mathOpsInstance, null);
            }
        }

    }

    private static bool AskAnotherCal()
    {
        WriteLineTools.LogQuestion("Do you want to perform another operation? (YES|no)");
        return ReadLineTools.GetBoolean("yes", "no", true);
    }

    private static void DisplayTitle()
    {
        Console.WriteLine();
        Console.WriteLine(".d88b    db    8    .d88b 8    8 8       db    88888 .d88b. 888b. ");
        Console.WriteLine("8P      dPYb   8    8P    8    8 8      dPYb     8   8P  Y8 8  .8 ");
        Console.WriteLine("8b     dPwwYb  8    8b    8b..d8 8     dPwwYb    8   8b  d8 8wwK' ");
        Console.WriteLine("`Y88P dP    Yb 8888 `Y88P `Y88P' 8888 dP    Yb   8   `Y88P' 8  Yb");
        Console.WriteLine();
    }
}
