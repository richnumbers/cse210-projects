public class CraftingRecipy
{

    public Sword Crafting(List<Materials> materials)
    {
        int copper = 0;
        int iron = 0;
        int DragonScale = 0;
        int DireWolfClaw = 0;
        bool ruby = false;
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
                    copper++;
                    break;

                case "Iron":
                    iron++;
                    break;

                case "Dragon Scale":
                    DragonScale++;
                    break;
                case "Dire Wolf Claw":
                    DireWolfClaw++;
                    break;
                case "Ruby":
                    ruby = true;
                    break;


            }

        }
        if (materials.Count() == 2)
        {

            if (copper == 2)
            {
                return new Sword("Copper Sword", "A sword made by pure Copper", 50);

            }

            if (iron == 2)
            {
                return new Sword("Iron Sword", "I Sword made from Pure Iron", 100);
            }

            if (copper == 1 && iron == 1)
            {
                return new Sword("Bronze Sword", "A sword that as a faint red glow", 75);
            }

            Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
            return null;
        }

        if (materials.Count() == 3)
        {
            if (copper == 2 && DragonScale == 1)
            {
                return new Sword("Flame Copper Sword", "A Sword that used dragon Scales to make it strong", 150);
            }

            if (copper == 1 && iron == 1 && DragonScale == 1)
            {
                return new Sword("Drakeblade", "An Alloy Blade with dragon fire", 125);
            }

            if (iron == 2 && DragonScale == 1)
            {
                return new Sword("DragonSteel Sword", "A sword that is stronger then the rest almost ready for a King", 175);

            }

            if (copper == 1 && iron == 1 && DireWolfClaw == 1)
            {
                return new Sword("Feral Edge", "A Fast Bleed-style Allow blade", 140);

            }

            if (copper == 2 && DireWolfClaw == 1)
            {
                return new Sword("WildFindBlad", "LightWeight Beast blade", 110);

            }

            if (iron == 2 && DireWolfClaw == 1)
            {
                new Sword("Dire Fang", "Brutal,Heavy-Hitting blade", 170);

            }
            Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
            return null;
        }

        if (ruby)
        {
            if (iron == 2 && DragonScale == 1)
            {
                return new Sword("Royal Blade", "A sword made for the king", 0);
            }

            return new Sword("Ruined Royal Blade", "A Sword that looks like it was made for a forgotten king", 0);
        }
        Console.WriteLine("As the Hammer hits and you start working everything starts to fall part and nothing is made");
        return null;

        }

      


    }

