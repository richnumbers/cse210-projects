public class Shop
{
    List<Materials> _shopInv = new List<Materials>();
    Materials materials;



    public void InitializeShop()
    {
        Materials Copper = new Materials("Copper", "A common metal used in crafting.", 10);
        Materials Iron = new Materials("Iron", "A strong metal used for weapons.", 20);
        
        Materials DragonScale = new Materials("Dragon Scale", "A rare scale that provides immense strength.", 100);
        Materials DireWolfClaw = new Materials("Dire Wolf Claw", "A sharp claw from a fierce creature.", 30);

        _shopInv.Add(Copper);
        _shopInv.Add(Iron);
        _shopInv.Add(DragonScale);
        _shopInv.Add(DireWolfClaw);
    }

    public int ShopInvCount()
    {
        return _shopInv.Count();
    }

    public void DisplayShop()
    {

        Console.WriteLine("Welcome to the Shop!");
        Console.WriteLine("Available Materials:");
        for (int i = 0; i < _shopInv.Count; i++)
        {
            Console.WriteLine($"-{i + 1} {_shopInv[i].GetName()} - {_shopInv[i].GetDescription()} (Cost: {_shopInv[i].GetGoldCost()} gold)");
        }
    }

    public Materials BuyMaterial(int gold)
    {
        Console.WriteLine("What are you buying? (enter the number from the shop list)");
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice < 0 || choice >= _shopInv.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return null;
        }

        if (_shopInv[choice].GetGoldCost() > gold)
        {
            Console.WriteLine("You do not have enough gold to buy this material.");
            return null;
        }
        gold -= _shopInv[choice].GetGoldCost();
        return _shopInv[choice];

    }
    

    
}