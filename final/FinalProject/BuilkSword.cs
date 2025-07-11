public class BuilkSword : SwordQuest
{
    private int _amout;
    private int _turnInAmout;
    Sword _sword;
    public BuilkSword(string name, int reward, string description, int amout, Sword sword) :
    base(name, reward, description)
    {
        _amout = amout;
        _sword = sword;
    }

    public override void requiredSwords()
    {
        Console.WriteLine(_sword.GetName());
    }

    public override void completelist(Sword sword)
    {
        if (sword.GetName() == _sword.GetName())
        {
            _turnInAmout++;
            if (_turnInAmout == _amout)
            {
                Questcomplect();

            }
            else
            {
                Console.WriteLine($"You have turn in {_turnInAmout} of {_amout} of {_sword.GetName()}");
            }
        }
    }
}