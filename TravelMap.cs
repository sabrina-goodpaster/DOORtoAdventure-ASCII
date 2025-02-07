using System;

public class TravelMap
{
    public static int gold = 400;
    public static int charLevel = 1;
    public static string weapon = "wooden club";
    public static string armor = "deerskin shirt";
    
    //game introduction placing the player in the town square for the first time
    public void StartTownSquare()
	{
        Console.Clear();
        Console.WriteLine("\nYou are " + StartGame.characterName + ", the renown " + StartGame.myClass + "!");
        Console.WriteLine("\n\nYour starting stats are:\n\n");
        Console.WriteLine("Character Level: " + charLevel);
        Console.WriteLine("Weapon: " + weapon);
        Console.WriteLine("Armor: " + armor);
        Console.WriteLine("Melee Bonus: " + StartGame.meleeBonus);
        Console.WriteLine("Ranged Bonus: " + StartGame.rangedBonus);
        Console.WriteLine("Spell Bonus: " + StartGame.spellBonus);
        Console.WriteLine("HP: " + StartGame.hp);
        Console.WriteLine("AC: " + StartGame.ac);
        Console.WriteLine("Gold: " + gold + "\n\n");

        Console.WriteLine("Welcome to Wildwatch, adventurer! This is a small village in need of big help from someone like you. Fierce animals and terrible monsters have taken over the nearby woods. The villagers need someone to defeat them, in order to make the area safe again. If you defeat enough of the monsters, you might even summon the ledgendary RED DRAGON! If you can defeat the dragon, then you will be heralded as a true hero! Good luck.\n");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        TownSquare();
    }

    public void TownSquare()
    {
        string moveSelection = "";

        Console.Clear();
        Console.WriteLine("You are standing in the beautiful town square of Wildwatch. From here, you see a quaint two story INN, a blacksmith working hard at an outdoor forge, the modest hut of the town sage, and a winding path leading into the dark woods.\n\n");

        //player selects where to go to next
        while (moveSelection is not "B" and not "A" and not "S" and not "I" and not "C")
        {
            Console.WriteLine("Where would you like to go, " + StartGame.characterName + "?");
            Console.WriteLine("(B) Visit the Blacksmith\r\n(A) Adventure in the Woods\r\n(S) Visit the Sage Hut\r\n(I) Visit the INN\r\n(C) View Character Status");

            moveSelection = (Console.ReadLine());
            moveSelection = moveSelection.ToUpper();
            Console.WriteLine(moveSelection);
        }
        
    }
    public void Blacksmith()
    {
        Console.WriteLine("You are at the Blacksmith.");
    }

    public void SageHut()
    {
        Console.WriteLine("You are at the Sage's Hut.");
    }

    public void INN()
    {
        Console.WriteLine("You are at the INN.");
    }
}
