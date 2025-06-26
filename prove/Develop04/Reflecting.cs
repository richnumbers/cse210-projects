public class reflecting : Activity
{
    private int _reflectionCount;
    private string[] _reflectionPrompts = new string[]
    {
        "What is something you are grateful for today?",
        "What is a challenge you faced recently and how did you overcome it?",
        "What is a lesson you learned from a past experience?",
        "How do you feel about your current situation in life?",
        "What are your goals for the next month?"
    };

    private string[] _reflectionResponses = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?"
    };    
    

    public reflecting(string activityName, string activityDescription, int reflectionCount)
        : base(activityName, activityDescription)
    {
        _reflectionCount = reflectionCount;
    }

    public void StartReflectingExercise()
    {
        
        Console.WriteLine($"Starting {GetActivityName()} for {_reflectionCount} seconds.");
        loading();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_reflectionCount);
        Random random = new Random();
         int promptIndex = random.Next(_reflectionPrompts.Length);
        Console.WriteLine(_reflectionPrompts[promptIndex]);
        Console.WriteLine("when you are ready, press enter to continue...");
        Console.ReadLine();
        Console.WriteLine("You begin in...");

        Countdown();
        Console.Clear();
        while (DateTime.Now < endTime)
        {

            int responseIndex = random.Next(_reflectionResponses.Length);
            Console.WriteLine(_reflectionResponses[responseIndex]);
            Countdown();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
        }
        loading();
        
        Console.WriteLine("Reflecting exercise completed.");
    }
}