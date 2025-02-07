using System;

public class StartGame()
{

    public static string characterName = "";
    int classSelection = 0;
    public static string myClass = "";
    public static int meleeBonus, rangedBonus, spellBonus, hp, ac;



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

        //ask player for a name between 3-20 characters, and save it
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

        //ask player for a class number selection, 1-3, and save it
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

            InitialStats(classSelection);

            }

        //set game stats based on class
        void InitialStats(int classNum)
        {
           

            if (classNum == 1)
            {
                meleeBonus = 5;
                rangedBonus = 2;
                spellBonus = -4;
                hp = 14;
                ac = 12;
            }
            else if (classNum == 2)
            {
                meleeBonus = 2;
                rangedBonus = 5;
                spellBonus = -2;
                hp = 10;
                ac = 15;
            }
            else {
                meleeBonus = -2;
                rangedBonus = 2;
                spellBonus = 5;
                hp = 7;
                ac = 10;
            }

        }

        //go back to Program.cs for next steps
    }
}