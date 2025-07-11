public class Shop
{
    List<Materials> ShopInv = new List<Materials>();
    Materials materials;



    public void InitializeShop()
    {
        Materials Copper = new Materials("Copper", "A common metal used in crafting.", 10);
        Materials Iron = new Materials("Iron", "A strong metal used for weapons.", 20);
        
        Materials DragonScale = new Materials("Dragon Scale", "A rare scale that provides immense strength.", 100);
        Materials DireWolfClaw = new Materials("Dire Wolf Claw", "A sharp claw from a fierce creature.", 30);

        ShopInv.Add(Copper);
        ShopInv.Add(Iron);
        ShopInv.Add(DragonScale);
        ShopInv.Add(DireWolfClaw);
    }

    public int ShopInvCount()
    {
        return ShopInv.Count();
    }

    public void DisplayShop()
    {

        Console.WriteLine("Welcome to the Shop!");
        Console.WriteLine("Available Materials:");
        for (int i = 0; i < ShopInv.Count; i++)
        {
            Console.WriteLine($"-{i + 1} {ShopInv[i].GetName()} - {ShopInv[i].GetDescription()} (Cost: {ShopInv[i].GetGoldCost()} gold)");
        }
    }

    public Materials BuyMaterial(int gold)
    {
        Console.WriteLine("What are you buying? (enter the number from the shop list)");
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice < 0 || choice >= ShopInv.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return null;
        }

        if (ShopInv[choice].GetGoldCost() > gold)
        {
            Console.WriteLine("You do not have enough gold to buy this material.");
            return null;
        }
        gold -= ShopInv[choice].GetGoldCost();
        return ShopInv[choice];

    }
    

    
}