using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Player player = new Player();
        Shop shop = new Shop();
        shop.InitializeShop();



        

            
                bool playing = true;

while (playing)
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════╗");
    Console.WriteLine("║      BlackSmiths MENU    ║");
    Console.WriteLine("╠══════════════════════════╣");
    Console.WriteLine("║ 1. Shop                  ║");
    Console.WriteLine("║ 2. Craft a Sword         ║");
    Console.WriteLine("║ 3. View Materials        ║");
    Console.WriteLine("║ 4. View Swords           ║");
    Console.WriteLine("║ 5. Craft swords          ║");
    Console.WriteLine("║ 6. Turn In Quest Swords  ║");
    Console.WriteLine("║ 7. Save and Quit         ║");
    Console.WriteLine("╚══════════════════════════╝");
    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
         Console.WriteLine("╔══════════════════════════╗");
         Console.WriteLine("║      Shops MENU          ║");
         Console.WriteLine("╠══════════════════════════╣");
         Console.WriteLine("║ 1. Buy                   ║");
         Console.WriteLine("║ 2. Sell Swords           ║");
         Console.WriteLine("╚══════════════════════════╝");
         Console.WriteLine($"Gold - {player.getgold()}");

        Console.Write("Choose an option: ");

        input = Console.ReadLine();
                    if (input == "1")
                    { player.BuyMaterial(shop); }
                    else if (input == "2")
                    {
                        player.SellSword();
                    }
            break;

        case "2":
            player.StartCrafting();
            break;

        case "3":
            player.getmaterials(); 
            Console.ReadLine();
            
            break;

        case "4":
            player.GetSwords();
            Console.ReadLine();                    
            break;

        case "5":
             player.StartCrafting();
            Console.ReadLine();
            break;

        case "6":
         throw new NotImplementedException("This feature has not been made yet.");
        
        case "7":
            Console.WriteLine("Game saved. Goodbye!");
            playing = false;
            break;

        default:
            Console.WriteLine("Invalid option. Press Enter to try again.");
            Console.ReadLine();
            break;
    }
}

            }
            
           
        }
        
        

        
    

       

    
       

      
    
