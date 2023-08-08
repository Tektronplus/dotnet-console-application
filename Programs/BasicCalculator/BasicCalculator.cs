using app.Programs.Tools;

namespace app.Programs.BasicCalculator;

public class BasicCalculator
{
    public BasicCalculator()
    {
        WriteLineTools.LogInfo("Basic calculator instantiated!");
    }

    public void StartProgram()
    {
        WriteLineTools.LogInfo("Basic calculator started!");
        WriteLineTools.LogBold("Select the mathematical operation:");


        SumOp();
    }
    private void SumOp()
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

    private void MultiplicationOp()
    {
        Console.WriteLine("Mulit op");
    }
}
