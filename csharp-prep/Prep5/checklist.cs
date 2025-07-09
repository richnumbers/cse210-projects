

public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;


    public Checklist(string name, string description, int points, bool isComplete, string goalType, int targetCount, int bonusPoints)
        : base(name, description, points, isComplete)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;


    }

    public override int recordEvent()
    {
        if (_timesCompleted >= _targetCount)
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }

        _timesCompleted++;

        if (_timesCompleted == _targetCount)
        {
            Console.WriteLine("You have completed the checklist goal: " + getName() + " and earned a bonus of " + _bonusPoints + " points!");
            return getPointsValue() + _bonusPoints;
        }

        Console.WriteLine($"You have completed the checklist goal:  {getName()} Current count:  {_timesCompleted}");
        return getPointsValue();
    }


    public override int getPoints()
    {
        if (_timesCompleted >= _targetCount)
        {
            return getPointsValue() + _bonusPoints;
        }
        return getPointsValue();
    }

    public override void getStatus()
    {
        if (_timesCompleted >= _targetCount)
        {

            Console.WriteLine($"[X]  Checklist goal '{getName()}': Completed {_timesCompleted}/{_targetCount} times. Total points: {getPoints()}");


        }
        else
        {
            Console.WriteLine($"[ ]  Checklist goal '{getName()}': Completed {_timesCompleted}/{_targetCount} times. Total points: {getPoints()}");
        }
    }

    public override bool isComplete()
    {
        return _timesCompleted >= _targetCount;
    }
    
    public int getTimesCompleted()
    {
        return _timesCompleted;
    }

    public int getTargetCount()
    {
        return _targetCount;
    }

    public int getBonusPoints()
    {
        return _bonusPoints;
    }

    public void setTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

}