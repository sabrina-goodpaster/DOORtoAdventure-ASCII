using System;
using TextAdventure;

public class TravelMap
{
  
    //game introduction placing the player in the town square for the first time
    public void StartTownSquare()
	{
        //create all weapons used in the game
        Weapon weaponcreate = new Weapon();
        weaponcreate.CreateWeapons();

        //create all armor in the game
        Armor armorcreate = new Armor();
        armorcreate.CreateArmor();

        Console.Clear();
        Console.WriteLine("\nYou are " + Character.characterName + ", the renown " + Character.myClass + "!");
        Console.WriteLine("Welcome to Wildwatch, adventurer! This is a small village in need of big help from someone like you. Fierce animals and terrible monsters have taken over the nearby woods. The villagers need someone to defeat them, in order to make the area safe again. If you defeat enough of the monsters, you might even summon the ledgendary RED DRAGON! If you can defeat the dragon, then you will be heralded as a true hero! Good luck.\n");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        TownSquare();
    }

    //Each time the player moves to the town square, this description loads
    public void TownSquare()
    {
        //account for possible null value for moveSelection with string?
        string? moveSelection = "";

        Console.Clear();
        Console.WriteLine("You are standing in the beautiful town square of Wildwatch. From here, you see a quaint two story INN, a blacksmith working hard at an outdoor forge, the modest hut of the town sage, and a winding path leading into the dark woods.\n\n");

        //player selects where to go to next
        while (moveSelection is not "B" and not "A" and not "S" and not "I" and not "C")
        {
            Console.WriteLine("Where would you like to go, " + Character.characterName + "?");
            Console.WriteLine("(B) Visit the Blacksmith\r\n(A) Adventure in the Woods\r\n(S) Visit the Sage Hut\r\n(I) Visit the INN\r\n(C) View Character Status");

            moveSelection = (Console.ReadLine());

            //accept the upper or lower case letter as an appropriate selection
            //account for possible null value with moveSelection!
            moveSelection = moveSelection!.ToUpper();
        }

        if (moveSelection is "B")
        {
            Console.Clear();
            Console.WriteLine("You approach the blacksmith working hard at his forge. Weapons and armor for sale are laid out on a table beside him.");
            
            //run blacksmith shop interaction
            Blacksmith();
        }
        
    }

    //blacksmith shop interaction
    public void Blacksmith()
    {
        //account for possible null value for moveSelection with string?
        string? aorWSelection = "";

        //player selects armor or weapon list
        while (aorWSelection is not "A" and not "W" and not "R")
        {
            Console.WriteLine("The blacksmith looks up at you and asks, \"Are you interested in any wares?\"");
            Console.WriteLine("(A) Armor\r\n(W) Weapons\r\n(R) Return to Town Square");

            aorWSelection = (Console.ReadLine());

            //accept the upper or lower case letter as an appropriate selection
            //account for possible null value with aorWSelection!
            aorWSelection = aorWSelection!.ToUpper();
        }

        //if player selects to shop for armor
        if (aorWSelection is "A")
        {
            string? aSelection = "";

            if (Character.charLevel >= 1 && Character.charLevel <= 2)
            {
                Console.Clear();

                while (aSelection is not "L" and not "C" and not "B" and not "R")
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("|           (L) Leather Armor - 100g              |");
                    Console.WriteLine("|           (C) Chain Tunic   - 300g              |");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("|           (B) Back to Blacksmith                |");
                    Console.WriteLine("|           (R) Return to Town Square             |");
                    Console.WriteLine("|                                                 |");
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("\nYour current armor: " + Character.armor);
                    Console.WriteLine("Your current gold: " + Character.gold);
                    Console.WriteLine("\nPlease enter the letter of your selection.");

                    aSelection = (Console.ReadLine());

                    //accept the upper or lower case letter as an appropriate selection
                    //account for possible null value with aSelection!
                    aSelection = aSelection!.ToUpper();
                }

                //if player selects to return to town square
                if (aSelection is "R")
                {
                    TownSquare();
                }

                //if player selects to return to Blacksmith
                if (aSelection is "B")
                {
                    Blacksmith();
                }

                //if player selects to purchase Leather
                if (aSelection is "L")
                {
                    //add code to check for gold balance, debit gold, add purchased armor to inventory, return user to blacksmith
                    if (Character.gold >= 100)
                    {
                        Character.gold = (Character.gold - 100);
                        Character.armor = "Leather";
                        Console.WriteLine("The blacksmith smiles as you hand over the gold and take the armor. You are now equipped with " + Character.armor + " and have " + Character.gold + " remaining!\n\nPress any key to continue.");
                        Console.ReadKey();
                        //purchase complete. return to Blacksmith main menu
                        Blacksmith();
                    }

                    //character does not have money for the purchase - text from blacksmith and return to town square
                    else
                    {
                        Console.WriteLine("The blacksmith frowns as you attempt to take the armor at less than the asking price. \"Be off until you have more gold!\" he chides, sending you back to the Town Square.\n\nPress any key to continue.");
                        Console.ReadKey();

                        TownSquare();
                    }
                }

                //if player selects to purchase Chain Tunic
                if (aSelection is "C")
                {
                     //character has money for purchase - debit gold, add purchased armor to inventory, return user to blacksmith
                     if (Character.gold >= 300)
                        {
                            Character.gold = (Character.gold - 300);
                            Character.armor = "Chain Tunic";
                            Console.WriteLine("The blacksmith smiles as you hand over the gold and take the armor. You are now equipped with " + Character.armor + " and have " + Character.gold + " gold remaining!\n\nPress any key to continue.");
                            Console.ReadKey();

                            Blacksmith();
                        }

                        //character does not have money for the purchase - text from blacksmith and return to town square
                      else
                        {
                            Console.WriteLine("The blacksmith frowns as you attempt to take the armor at less than the asking price. \"Be off until you have more gold!\" he chides, sending you back to the Town Square.\n\nPress any key to continue.");
                            Console.ReadKey();

                            TownSquare();
                        }
                }
            }

            //if player selects to shop for weapons
            if (aorWSelection is "W")
            {

            }

            //if player selects to return to town square
            if (aorWSelection is "R")
            {
                TownSquare();
            }






        }
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
