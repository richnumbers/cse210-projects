using System.Diagnostics;

public abstract class amour
{
    private string _name;
    private string _type;
    private List<string> _craftingMaterials = new List<string>();


    public amour(string name, string type, List<string> craftingMaterials)
    {
        _name = name;
        _type = type;
        _craftingMaterials = craftingMaterials;
    }


    public abstract void craft();

    
}