using LeetCode.Core;

public interface ITask 
{
    public string Name { get; }

    public string Description { get; }

    public Dificulty Dificulty { get; }

    public void Invoke(){
        Print();
    }

    public void Print()
    {
        Console.Clear();
        Console.ForegroundColor = (ConsoleColor)Dificulty;
        Console.WriteLine(Name+"\n\n"+Description+"\n");
        Calculate();
        Console.ResetColor();
        Console.ReadKey();
    }

    public void Calculate();
}