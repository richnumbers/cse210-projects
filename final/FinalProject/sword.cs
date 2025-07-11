

public class Sword
{

    public string _name;
    public string _description;
    public int _gold;
    public bool _activeQuest = false;

   
    public Sword(string name, string description, int gold)
    {
        _name = name;
        _description = description;
        _gold = gold;

    }

    

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetGold()
    {
        return _gold;
    }





   

}