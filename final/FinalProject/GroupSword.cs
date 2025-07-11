using System.Data;

public class GroupSword : SwordQuest
{
    private List<int> _amouts;
    private List<Sword> _swords;
    private List<int> _amoutTurnIn;
    public GroupSword(string name, int reward, string description, List<int> amouts, List<Sword> swords) :
    base(name, reward, description)
    {
        _amouts = amouts;
        _swords = swords;

    }

    public override void requiredSwords()
    {
        for (int i = 0; i < _swords.Count(); i++)
        {
            Console.WriteLine($"you need {_swords[i].GetName()} with {_amouts[i]} of that sword");
        }
    }

    public override void completelist(Sword sword, Player player)
    {
        for (int i = 0; i < _swords.Count(); i++)
        {
            if (sword.GetName() == _swords[i].GetName())
            {
                if (_amoutTurnIn[i] < _amouts[i])
                {
                    _amoutTurnIn[i]++;
                    Console.WriteLine($"you have turn in {_amoutTurnIn[i]} needed of {_amouts[i]}");
                }
                else
                {
                    Console.WriteLine("That sword is all ready at the Max");
                }

            }

        }

        for (int i = 0; i < _amouts.Count; i++)
        {
            if (_amoutTurnIn[i] < _amouts[i])
            {
                return;
            }
        }


        Questcomplect();
    }



    public override void turnInAmout()
    {
        for (int i = 0; i < _swords.Count(); i++)
        {
            Console.WriteLine($"you have turn in {_amoutTurnIn[i]} needed of {_amouts[i]}");
        }
    }

    public List<int> GetTurnedInList()
{
    return _amoutTurnIn; 
}


}


