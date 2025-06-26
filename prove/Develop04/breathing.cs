public class Breathing : Activity
{
    private int _breathCount;

    public Breathing(string activityName, string activityDescription,  int breathCount)
        : base(activityName, activityDescription)
    {
        _breathCount = breathCount;
    }

    public void StartBreathingExercise()
    {
        Console.Clear();
        Console.WriteLine($"Starting {GetActivityName()} for {_breathCount} seconds.");
        Console.WriteLine("get ready to focus on your breathing...");
        loading();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_breathCount);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"Breathe in...");
            Countdown();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Breathe out...");
            Countdown();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
        }
        loading();
        Console.WriteLine("Breathing exercise completed.");
    }
}