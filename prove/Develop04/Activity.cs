public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;

    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b");
        }

    }

    public void loading()
    {
        string[] loading = { "/", "-", "\\", "|" };
        for (int i = 0; i < 5; i++)
        {
            Console.Write(loading[i % loading.Length]);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();

    }
    //chat GPT help me write this loading code so it can go through the array

}