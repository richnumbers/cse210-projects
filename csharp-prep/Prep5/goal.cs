public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;


    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }



    public abstract int  recordEvent();
    public abstract void getStatus();

    public abstract int getPoints();

    public abstract bool isComplete();

    public string getName()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public int getPointsValue()
    {
        return _points;
    }


}
