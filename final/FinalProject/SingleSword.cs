public class SingleSword : SwordQuest
{

    Sword _sword;
    public SingleSword(string name, int reward, string description, Sword sword) :
    base(name, reward, description)
    {
        _sword = sword;

    }

    public override void requiredSwords()
    {
        Console.WriteLine(_sword.GetName());
    }

    public override void completelist(Sword sword, Player player)
    {
        if (sword.GetName() == _sword.GetName())
        {
            Questcomplect();
            setunactive();
            player.RemoveSword(sword);


        }

    }

    public override void turnInAmout()
    {
         Console.WriteLine(_sword.GetName());
       
    }

    

}