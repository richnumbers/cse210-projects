using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class Player
{
    private int _input;
    private bool craf = true;


    private int playerGold = 30;
    List<Materials> PlayerInv = new List<Materials>();
    List<Sword> PlayerSwords = new List<Sword>();
    List<Materials> craftinglist = new List<Materials>();

    CraftingRecipy crafting = new CraftingRecipy();


    public void BuyMaterial(Shop shop)
    {
        shop.DisplayShop();
        Materials materials = shop.BuyMaterial(playerGold);

        if (materials != null)
        {
            PlayerInv.Add(materials);
            playerGold -= materials.GetGoldCost();
        }

    }



    public void SellSword()
    {
        if (PlayerSwords.Count == 0)
        {
            Console.WriteLine("You have no swords to sell");

        }
        else
        {
            Console.WriteLine("Swords that can be sold");
            for (int i = 0; i < PlayerSwords.Count; i++)
            {
                Console.WriteLine($"{i + 1} - Gold: {PlayerSwords[i].GetGold()} - Name {PlayerSwords[i].GetName()} - Description {PlayerSwords[i].GetDescription()} ");

            }

            Console.Write("What sword do you wish to sale? ");
            _input = int.Parse(Console.ReadLine()) - 1;


            if (_input < 0 || _input > PlayerSwords.Count)
            {
                Console.WriteLine("Not a vailed number");
            }
            else
            {
                playerGold += PlayerSwords[_input].GetGold();
                PlayerSwords.Remove(PlayerSwords[_input]);
            }



        }
    }

    public void StartCrafting()
    {
        craf = true;
        while (craf)
        {

            for (int i = 0; i < PlayerInv.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {PlayerInv[i].GetName()}");
            }
            Console.WriteLine("What do you wish to craft with?");
            _input = int.Parse(Console.ReadLine()) - 1;
            craftinglist.Add(PlayerInv[_input]);
            Console.WriteLine($"{PlayerInv[_input].GetName()} has been added into the Furnace for smelting");
            PlayerInv.Remove(PlayerInv[_input]);
            Console.WriteLine("Do you want to start crafting the sword? 1 Yes\n 2 No ");
            _input = int.Parse(Console.ReadLine());
            if (_input == 1) { craf = false; }


        }

        Sword sword = crafting.Crafting(craftinglist);
        craftinglist.Clear();
        if (sword != null)
        {
            Console.WriteLine($"You have crafted {sword.GetName()}");
            PlayerSwords.Add(sword);
        }


    }

    public int getgold()
    {
        return playerGold;
    }

    public void getmaterials()
    {
        if (PlayerInv.Count == 0)
        {
            Console.WriteLine("As you look at your crafting list you noticed your shelfs are empty");

        }
        else foreach (Materials inv in PlayerInv)
            {
                Console.WriteLine(inv.GetName());
            }
    }

    public void GetSwords()
    {
        if (PlayerSwords.Count == 0 )
        {
            Console.WriteLine("As you look at your wall and shefls you noticed you do not have any sword out to show or any in the back");

        }
        else foreach (Sword sword in PlayerSwords)
        {
                Console.WriteLine(sword.GetName());
        }
        
    }

    
    }


