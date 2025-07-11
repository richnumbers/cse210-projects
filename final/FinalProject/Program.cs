using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

        Player player = new Player();
        Shop shop = new Shop();
        Qustline qustline = new Qustline();
       
        shop.InitializeShop();
        qustline.createquest();

        int craftcout = 3;
        bool playing = true;

        
        

while (playing)
        {

            qustline.TheQuestList(craftcout);


            Console.Clear();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║      BlackSmiths MENU    ║");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("║ 1. Shop                  ║");
            Console.WriteLine("║ 2. Craft a Sword         ║");
            Console.WriteLine("║ 3. View Materials        ║");
            Console.WriteLine("║ 4. View Swords           ║");
            Console.WriteLine("║ 5. Turn In Quest Swords  ║");
            Console.WriteLine("║ 6. Save and Quit         ║");
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
                    if (player.hasmateriasl() == 0)
                    {
                        Console.WriteLine("You have nothing to craft with");
                        Console.ReadLine();
                        break;

                    }
                    player.StartCrafting(ref craftcout);
                    Console.ReadLine();
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

                    Console.Clear();
                    Console.WriteLine("╔══════════════════════════╗");
                    Console.WriteLine("║     🧾 QUEST MENU         ║");
                    Console.WriteLine("╠══════════════════════════╣");
                    Console.WriteLine("║ 1. Turn In Sword         ║");
                    Console.WriteLine("║ 2. View Quest Info       ║");
                    Console.WriteLine("║ 3. Back to Main Menu     ║");
                    Console.WriteLine("╚══════════════════════════╝");
                    Console.Write("Choose an option: ");

                    input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            player.GetSwords();
                            Sword sword = player.ChooseSword();

                            qustline.questTurnin(sword, player);
                            Console.WriteLine(player.getgold());

                            Console.ReadLine();
                            break;

                        case "2":
                            qustline.Questswords();
                            Console.ReadLine();
                            break;

                        case "3":
                            break;




                    }
                    break;



                case "6":
                    Console.WriteLine("YOu think you can save the game but you can't....");
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
        
        

        
    

       

    
       

      
    
