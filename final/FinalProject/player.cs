using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class Player
{
    private int _input;
    private bool craf = true;


    private int _gold = 30;
    List<Materials> _playerInv = new List<Materials>();
    List<Sword> _playerSwords = new List<Sword>();
    List<Materials> _craftingList = new List<Materials>();

    CraftingRecipy _crafting = new CraftingRecipy();


    public void BuyMaterial(Shop shop)
    {
        shop.DisplayShop();
        Materials materials = shop.BuyMaterial(_gold);

        if (materials != null)
        {
            _playerInv.Add(materials);
            _gold -= materials.GetGoldCost();
        }

    }



    public void SellSword()
    {
        if (_playerSwords.Count == 0)
        {
            Console.WriteLine("You have no swords to sell");

        }
        else
        {
            Console.WriteLine("Swords that can be sold");
            for (int i = 0; i < _playerSwords.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Gold: {_playerSwords[i].GetGold()} - Name {_playerSwords[i].GetName()} - Description {_playerSwords[i].GetDescription()} ");

            }

            Console.Write("What sword do you wish to sale? ");
            _input = int.Parse(Console.ReadLine()) - 1;


            if (_input < 0 || _input > _playerSwords.Count)
            {
                Console.WriteLine("Not a vailed number");
            }
            else
            {
                _gold += _playerSwords[_input].GetGold();
                _playerSwords.Remove(_playerSwords[_input]);
            }



        }
    }

    public void StartCrafting(ref int craftcout)
    {
        craf = true;
        while (craf)
        {
            if (_playerInv.Count == 0)
            {
                break;
            }
            for (int i = 0; i < _playerInv.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {_playerInv[i].GetName()}");
            }
            Console.WriteLine("What do you wish to craft with?");
            _input = int.Parse(Console.ReadLine()) - 1;
            _craftingList.Add(_playerInv[_input]);
            Console.WriteLine($"{_playerInv[_input].GetName()} has been added into the Furnace for smelting");
            _playerInv.Remove(_playerInv[_input]);
            Console.WriteLine("Do you want to start crafting the sword? 1 Yes\n 2 No ");
            _input = int.Parse(Console.ReadLine());
            if (_input == 1) { craf = false; }


        }

        Sword sword = _crafting.Crafting(_craftingList);
        _craftingList.Clear();
        if (sword != null)
        {
            Console.WriteLine($"You have crafted {sword.GetName()}");
            _playerSwords.Add(sword);
            craftcout++;
        }


    }

    public int getgold()
    {
        return _gold;
    }

    public void RemoveSword(Sword sword)
    {
        for (int i = 0; i < _playerSwords.Count; i++)
        {
            if (_playerSwords[i].GetName() == sword.GetName())
            {
                _playerSwords.Remove(_playerSwords[i]);
            }
        }
    }

    public void getmaterials()
    {
        if (_playerInv.Count == 0)
        {
            Console.WriteLine("As you look at your crafting list you noticed your shelfs are empty");

        }
        else foreach (Materials inv in _playerInv)
            {
                Console.WriteLine(inv.GetName());
            }
    }

    public int hasmateriasl()
    {
        return _playerInv.Count;
    }

    public void GetSwords()
    {
        if (_playerSwords.Count == 0)
        {
            Console.WriteLine("As you look at your wall and shefls you noticed you do not have any sword out to show or any in the back");

        }
        else foreach (Sword sword in _playerSwords)
            {
                Console.WriteLine(sword.GetName());
            }

    }

    public void addgold(int amout)
    {
        _gold += amout;
    }

    public Sword ChooseSword()
    {
        Console.WriteLine("Pick a sword to turn in.");
        int choice = int.Parse(Console.ReadLine()) - 1;
        return _playerSwords[choice];
    }


  


}


