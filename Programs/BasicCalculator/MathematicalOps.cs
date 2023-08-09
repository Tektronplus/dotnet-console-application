namespace app.Programs.BasicCalculator;

using app.Programs.Tools;

public class MathematicalOps
{
    public static void SumOp()
    {
        WriteLineTools.LogQuestion("How many number you want to sum?");
        int numValues = ReadLineTools.GetNumber();
        int sum = 0;
        for (int i = 1; i <= numValues; i++)
        {
            WriteLineTools.LogBold("Digit the value n°" + i + ":");
            sum += ReadLineTools.GetNumber();
        }

        WriteLineTools.LogBold("The result is: " + sum);
    }
    public void SubtractionOp()
    {
        Console.WriteLine("SubtractionOp");
    }

    public void MultiplicationOp()
    {
        Console.WriteLine("MultiplicationOp");
    }

    public void DivisionOp()
    {
        Console.WriteLine("DivisionOp");
    }
}


