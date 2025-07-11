public class Materials
{
    string _name;
    string _description;
    int _goldCost;

   // Materials Ruby = new Materials("Ruby", "A precious gem that enhances weapon power.", 50);

    public Materials(string name, string description, int goldCost)
    {
        _name = name;
        _description = description;
        _goldCost = goldCost;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetGoldCost()
    {
        return _goldCost;
    }


       

    



}