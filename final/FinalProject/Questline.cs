using System.Diagnostics.CodeAnalysis;

public class Qustline
{

    private List<SwordQuest> _questlist = new List<SwordQuest>();
    private bool intro = true;
    public void createquest()
    {
        SwordQuest quest1 = new SingleSword("The Young Man", 150, "A young man from the village comes up to you wanted you to make him a basic copper Sworde", new Sword("Copper Sword", "A sword made by pure Copper", 50));
        SwordQuest quest2 = new BuilkSword("The Melta request", 400, "A group from the amry needs new sword made from iron", 3, new Sword("Iron Sword", "I Sword made from Pure Iron", 100));
        SwordQuest quest3 = new SingleSword("The sword that bleeds", 200, "A man is looking for a sword that can make monster bleed so when they run away he can still find them", new Sword("Feral Edge", "A Fast Bleed-style Allow blade", 140));
        SwordQuest quest4 = new GroupSword("The dragon killers", 700, "There is a group of man going to kill a dragon and they need a some quest to kill it", new List<int> { 2, 4 }, new List<Sword> { new Sword("Bronze Sword", "A sword that as a faint red glow", 75), new Sword("Dire Fang", "Brutal,Heavy-Hitting blade", 170) });

        _questlist.Add(quest1);
        _questlist.Add(quest2);
        _questlist.Add(quest3);
        _questlist.Add(quest4);

    }


    public void TheQuestList(int craftcout)
    {
        if (craftcout >= 3 && !_questlist[0].isComplete())
        {
            _questlist[0].setactive();
            if (intro)
            {
                intro = false;
                Story_Quest1();
                Console.WriteLine($" Quest Activated: {_questlist[0].getname()}");
            }
        }
        else if (craftcout >= 5 && !_questlist[1].isComplete())
        {
            _questlist[1].setactive();
            if (intro)
            {
                intro = false;
                Story_Quest2();
                Console.WriteLine($" Quest Activated: {_questlist[1].getname()}");
            }
        }
        else if (craftcout >= 7 && !_questlist[2].isComplete())
        {
            _questlist[2].setactive();
            if (intro)
            {
                intro = false;
                Story_Quest3();
                Console.WriteLine($" Quest Activated: {_questlist[2].getname()}");
            }
        }
        else if (craftcout >= 10 && !_questlist[3].isComplete())
        {
            _questlist[3].setactive();
            if (intro)
            {
                intro = false;
                Story_Quest4();
                Console.WriteLine($" Quest Activated: {_questlist[3].getname()}");
            }
        }
    }

    public void questTurnin(Sword sword, Player player)
    {
        foreach (SwordQuest quest in _questlist)
        {
            if (quest.IsActiveQuest())
            {
                quest.completelist(sword, player);
                if (quest.isComplete())
                {
                    player.addgold(quest.getreward());
                    if (quest.getname() == "The Young Man") Story_Quest1_Complete();
                    else if (quest.getname() == "The Melta request") Story_Quest2_Complete();
                    else if (quest.getname() == "The sword that bleeds") Story_Quest3_Complete();
                    else if (quest.getname() == "The dragon killers") Story_Quest4_Complete();
                    intro = true;
                }

                break;
            }

        }
    }

    public void Questswords()
    {
        foreach (SwordQuest quest in _questlist)
        {
            if (quest.IsActiveQuest())
            {
                Console.WriteLine(quest.getname());
                quest.requiredSwords();



                break;
            }

        }

    }

    public void Story_Quest1()
    {
        Console.WriteLine("A young man walks into your forge, eyes wide with hope.");
        Console.WriteLine("“Can you craft me a sword? Something simple. Something... copper?”");
        Console.WriteLine();
        Console.ReadLine();
    }

    public void Story_Quest2()
    {
        Console.WriteLine("A rugged soldier slams a parchment on your workbench.");
        Console.WriteLine("“Orders from the front. We need iron swords. A lot of them. Fast.”");
        Console.WriteLine();
        Console.ReadLine();
    }

    public void Story_Quest3()
    {
        Console.WriteLine("A hunter leans in, lowering his voice.");
        Console.WriteLine("“I need a blade that bleeds monsters, so I can find them even when they run.”");
        Console.WriteLine();
        Console.ReadLine();
    }

    public void Story_Quest4()
    {
        Console.WriteLine("A group of mercenaries stomp in, smelling of smoke and ambition.");
        Console.WriteLine("“We’re going to slay a dragon. But we need weapons worthy of the task.”");
        Console.WriteLine();
        Console.ReadLine();
    }

    public void Story_Quest1_Complete()
    {
        Console.WriteLine("🧑 The young man returns, eyes glowing as he sees the finished sword.");
        Console.WriteLine("“Thank you! With this, I can finally defend my village.”");
        Console.WriteLine("🎉 Quest Complete: The Young Man");
        Console.WriteLine();
    }

    public void Story_Quest2_Complete()
    {
        Console.WriteLine("🪖 The soldier picks up the iron swords, nodding with respect.");
        Console.WriteLine("“Perfect. These will save lives.”");
        Console.WriteLine("🎉 Quest Complete: The Melta Request");
        Console.WriteLine();
    }

    public void Story_Quest3_Complete()
    {
        Console.WriteLine("🏹 The hunter tests the blade’s edge and smiles.");
        Console.WriteLine("“A clean cut... they’ll bleed for miles. I’ll never lose one again.”");
        Console.WriteLine("🎉 Quest Complete: The Sword That Bleeds");
        Console.WriteLine();
    }

    public void Story_Quest4_Complete()
    {
        Console.WriteLine("🐉 The mercenary leader grins, hefting the weapons.");
        Console.WriteLine("“With these, we’ll bring down the beast. You’ve done your part.”");
        Console.WriteLine("🎉 Quest Complete: The Dragon Killers");
        Console.WriteLine();
    }

    public List<SwordQuest> GetQuests()
    {
        return _questlist;
    }
    

    }
