using System;

public class StartGame()
{

    string characterName = "";
    int classSelection = 0;
    string myClass = "";



    public void GameIntro()
    {
        Console.Title = "DOOR to Adventure";
        Console.ForegroundColor = ConsoleColor.Cyan;
        string title = @"
               ____   ___   ___  ____    _             _       _                 _                  
              |  _ \ / _ \ / _ \|  _ \  | |_ ___      / \   __| |_   _____ _ __ | |_ _   _ _ __ ___ 
              | | | | | | | | | | |_) | | __/ _ \    / _ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
              | |_| | |_| | |_| |  _ <  | || (_) |  / ___ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/
              |____/ \___/ \___/|_| \_\  \__\___/  /_/   \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|
                                                                                                                                                         ";

        Console.WriteLine(title);
        Console.ResetColor();
        Console.WriteLine("\n\n\n");

        NameCharacter();

        //ask player for a name, and save it
        void NameCharacter()
        {
            
            while (characterName.Length < 3 || characterName.Length > 20)
            {
                Console.WriteLine("Please enter your character's name (between 3 and 20 characters)");
                characterName = Console.ReadLine();
            }
            Console.WriteLine("Welcome, " + characterName + "! Press any key to continue to class selection.");
            Console.ReadKey();

            CharacterClass();
        }

        //ask player for a class selection, and save it
        void CharacterClass()
        {
            

            // Console.Clear();
            Console.WriteLine("\n\nWhich class would you like to choose for your character?\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1 Warrior - Highest melee damage dealer. Highest starting hitpoints.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2 Thief - Highest ranged damage dealer. Extra gold at the end of each battle.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("3 Wizard - Powerful combat and utility spells.");
            Console.ResetColor();

            string classAsString = "";

            while (classAsString is not "1" and not "2" and not "3")
                {

                Console.WriteLine("\nEnter 1 for Warrior, 2 for Thief, or 3 for Wizard.");
                classAsString = (Console.ReadLine());

                }
            classSelection = int.Parse(classAsString);

            if (classSelection == 1)
            {
                myClass = "warrior";
            }
            else if (classSelection == 2)
            {
                myClass = "thief";
            }
            else
            {
                myClass = "wizard";
            }

            Console.WriteLine("Your character, " + characterName + " is now a " + myClass + ".");

            InitialStats(classSelection);

            }

        void InitialStats(int classNum)
        {
            int meleeBonus, rangedBonus, spellBonus, hp, ac, gold;

            if (classNum == 1)
            {
                meleeBonus = 5;
                rangedBonus = 2;
                spellBonus = -4;
                hp = 14;
                ac = 12;
                gold = 400;
            }
            else if (classNum == 2)
            {
                meleeBonus = 2;
                rangedBonus = 5;
                spellBonus = -2;
                hp = 10;
                ac = 15;
                gold = 400;
            }
            else {
                meleeBonus = -2;
                rangedBonus = 2;
                spellBonus = 5;
                hp = 7;
                ac = 10;
                gold = 400;
            }

            Console.WriteLine("\nYou are " + characterName + ", the renown " + myClass + "!");
            Console.WriteLine("\n\nYour starting stats are:\n\n");
            Console.WriteLine("Melee Bonus: " + meleeBonus);
            Console.WriteLine("Ranged Bonus: " + rangedBonus);
            Console.WriteLine("Spell Bonus: " + spellBonus);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("AC: " + ac);
            Console.WriteLine("Gold: " + gold + "\n");
        }

    }
}