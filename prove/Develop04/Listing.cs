public class listing : Activity
{
    private int _duration;
    private int _cout;
    private string[] _listItems = new string[]
    {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes?"
    };

    public listing(string activityName, string activityDescription, int duration)
        : base(activityName, activityDescription)
    {
        _duration = duration;
    }

    public void StartListingExercise()
    {
        Console.WriteLine($"Starting {GetActivityName()}.");
        loading();
         Random random = new Random();
         int promptIndex = random.Next(_listItems.Length);
        Console.WriteLine(_listItems[promptIndex]);
        Console.WriteLine("Please list as many things as you can in the area above.");
        Countdown();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(">");
            Console.ReadLine();
            _cout++;
            
        
            
        }
        loading();
        Console.WriteLine($"You listed {_cout} items in the given area.");
        Console.WriteLine("Listing exercise completed.");
    }
}