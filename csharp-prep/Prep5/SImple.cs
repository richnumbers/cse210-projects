public class Simple : Goal
{
    private bool _completed;
    private int _points;

    public Simple(string name, string description, int points, bool isComplete)
        : base(name, description, points, isComplete)
    {
        _completed = isComplete;
        _points = points;
    }

    public override int recordEvent()
    {
        _completed = true;
        Console.WriteLine("You have completed the goal: " + getName());
        Console.WriteLine($"You earn  {_points}   for completing this goal.");
        return getPoints();
    }

    public override void getStatus()
    {
        if (_completed)
        {
            Console.WriteLine($"[X] Simple goal '{getName()}': Completed. Total points: {getPoints()}");
        }
        else
        {
            Console.WriteLine($"[ ] Simple goal '{getName()}': Not completed. Total points: {getPoints()}");
        }
        
    }

    public override int getPoints()
    {
        return _points; 
    }

    public override bool isComplete()
    {
        return _completed; 
    }
}