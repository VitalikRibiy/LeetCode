using LeetCode.Core;

internal class Program
{
    public static TasksMap Tasks { get; } = new TasksMap();

    private static void Main(string[] args)
    {
        ConsoleConfiguration.Configure();
        SelectTask();

    }

    public static void SelectTask()
    {
        Console.Clear();
        Console.WriteLine("Welcome, write the task number to select it");
        Tasks.Print();
        var isParsed = Int32.TryParse(Console.ReadLine(), out int taskId);
        if(isParsed && Tasks.IsKeyPresent(taskId))
        {
            Tasks[taskId].Invoke();
            SelectTask();
        }
        else
        {
            System.Console.WriteLine("Wrong input, please write correct number of task\nPress any key to continue...");
            Console.ReadKey();
            SelectTask();
        }
    }
}