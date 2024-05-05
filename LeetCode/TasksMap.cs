public class TasksMap {
    private SortedDictionary<int, ITask> tasks = new SortedDictionary<int, ITask>{
        { 2000, new ReversePrefixOfWord() },
        { 881, new BoatsToSavePeople() },
    };

    public ITask this[int index]
    {
        get
        {
            return tasks[index];
        }
    }

    public void Print(){
        foreach(var task in tasks){
            Console.ForegroundColor = (ConsoleColor)task.Value.Dificulty;
            Console.WriteLine($"{task.Key}.{task.Value.Name}");
        }
        Console.ResetColor();
        Console.Write("Select a task:");
    }

    public bool IsKeyPresent(int index) => tasks.Keys.Contains(index);
}