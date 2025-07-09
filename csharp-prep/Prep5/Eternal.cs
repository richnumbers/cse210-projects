using System.Diagnostics.CodeAnalysis;

public class Eternal : Goal
{
    private bool _completed;


    public Eternal(string name, string description, int points, bool isComplete)
        : base(name, description, points, isComplete)
    {
        _completed = isComplete;

    }

    public override int recordEvent()
    {
        _completed = true;
        Console.WriteLine($"You have completed the eternal goal:{getName()}");
        Console.WriteLine($"You earn {getPointsValue()} for completing this goal.");
        return getPointsValue();

    }

    public override void getStatus()
    {
        Console.WriteLine("Eternal goal status.");
        Console.WriteLine($"Eternal goal '{getName()}': Completed: {_completed}. Total points: {getPoints()}");
        Console.WriteLine($"Description: {getDescription()}");
    }

    public override int getPoints()
    {
        return getPointsValue();
    }

    public override bool isComplete()
    {
        return _completed
;
    }

    


}