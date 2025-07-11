public abstract class SwordQuest

{
    private string _name;
    private string _description;
    private int _amout;
    private int _reward;
    private bool _activeQuest = false;

    private bool _isCompleted = false;
    private Materials _RewardMeterials;


    public SwordQuest(string name, int reward, string description)
    {
        _name = name;
        _reward = reward;
        _description = description;
    }

    public string getname()
    {
        return _name;
    }

    public string getDescription()
    {
        return _description;
    }

    public bool IsActiveQuest()
    {
        return _activeQuest;
    }

    public void setactive()
    {
        _activeQuest = true;
    }

    public void Questcomplect()
    {
        _isCompleted = true;
    }

    public int getreward()
    {
        return _reward;
    }

 public bool isComplete()
{
    return _isCompleted;
}


    public int Reward()
    {
        return _reward;
    }

    public abstract void requiredSwords();

    public abstract void completelist(Sword sword);
}