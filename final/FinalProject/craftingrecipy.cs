public class CraftingRecipy
{

    public Sword Crafting(List<Materials> materials)
    {
        int _copper = 0;
        int _iron = 0;
        int _dragonScale = 0;
        int _direWolfClaw = 0;
        bool _ruby = false;
        if (materials.Count() > 4)
        {
            Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
            return null;
        }
        for (int i = 0; i < materials.Count(); i++)
        {
            switch (materials[i].GetName())
            {
                case "Copper":
                    _copper++;
                    break;

                case "Iron":
                    _iron++;
                    break;

                case "Dragon Scale":
                    _dragonScale++;
                    break;
                case "Dire Wolf Claw":
                    _direWolfClaw++;
                    break;
                case "Ruby":
                    _ruby = true;
                    break;


            }

        }

        ForgeAnimation();
        if (materials.Count() == 2)
        {

            if (_copper == 2)
            {
                return new Sword("Copper Sword", "A sword made by pure Copper", 50);

            }

            if (_iron == 2)
            {
                return new Sword("Iron Sword", "I Sword made from Pure Iron", 100);
            }

            if (_copper == 1 && _iron == 1)
            {
                return new Sword("Bronze Sword", "A sword that as a faint red glow", 75);
            }

            Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
            return null;
        }

        if (materials.Count() == 3)
        {
            if (_copper == 2 && _dragonScale == 1)
            {
                return new Sword("Flame Copper Sword", "A Sword that used dragon Scales to make it strong", 150);
            }

            if (_copper == 1 && _iron == 1 && _dragonScale == 1)
            {
                return new Sword("Drakeblade", "An Alloy Blade with dragon fire", 125);
            }

            if (_iron == 2 && _dragonScale == 1)
            {
                return new Sword("DragonSteel Sword", "A sword that is stronger then the rest almost ready for a King", 175);

            }

            if (_copper == 1 && _iron == 1 && _direWolfClaw == 1)
            {
                return new Sword("Feral Edge", "A Fast Bleed-style Allow blade", 140);

            }

            if (_copper == 2 && _direWolfClaw == 1)
            {
                return new Sword("WildFindBlad", "LightWeight Beast blade", 110);

            }

            if (_iron == 2 && _direWolfClaw == 1)
            {
                new Sword("Dire Fang", "Brutal,Heavy-Hitting blade", 170);

            }
            Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
            return null;
        }

        if (_ruby)
        {
            if (_iron == 2 && _dragonScale == 1)
            {
                return new Sword("Royal Blade", "A sword made for the king", 0);
            }

            return new Sword("Ruined Royal Blade", "A Sword that looks like it was made for a forgotten king", 0);
        }
        Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
        return null;

    }
        

        public void ForgeAnimation()
{
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();

        // Anvil only
        Console.WriteLine("     ");
        Console.WriteLine("     ");
        Console.WriteLine("     ");
        Console.WriteLine("     -------");
        Console.WriteLine("     |     \\");
        Console.WriteLine("     -------");
        Thread.Sleep(300);

        // Hammer raised
        Console.Clear();
        Console.WriteLine("     |");
        Console.WriteLine("     |");
        Console.WriteLine("     |");
        Console.WriteLine("     -------");
        Console.WriteLine("     |     \\");
        Console.WriteLine("     -------");
        Thread.Sleep(300);

        // Hammer lower
        Console.Clear();
        Console.WriteLine("     \\");
        Console.WriteLine("      \\");
        Console.WriteLine("       \\");
        Console.WriteLine("     -------");
        Console.WriteLine("     |     \\");
        Console.WriteLine("     -------");
        Thread.Sleep(300);

        // Hammer hit
        Console.Clear();
        Console.WriteLine("     ___");
        Console.WriteLine("    /###\\");
        Console.WriteLine("    \\###/");
        Console.WriteLine("     -------");
        Console.WriteLine("     |     \\");
        Console.WriteLine("     -------");
        Console.WriteLine("     *CLANG!*");
        Thread.Sleep(500);
    }

    // Final message
    Console.Clear();
    Console.WriteLine("💥 Sparks fly from the anvil as the metal cools...");
    Thread.Sleep(1000);
    Console.WriteLine();
    Thread.Sleep(1500);
}


      


    }

