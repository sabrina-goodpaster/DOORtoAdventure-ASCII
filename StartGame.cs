using System;

public class StartGame()
{

    string characterName = "";
    int classSelection = 0;
   


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

            string classAsString = "0";

            while (classAsString is not "1" and not "2" and not "3")
                {

                Console.WriteLine("\nEnter 1 for Warrior, 2 for Thief, or 3 for Wizard.");
                classAsString = (Console.ReadLine());

                }
            classSelection = int.Parse(classAsString);
            string myClass;

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
            int strength, dexterity, constitution, intelligence, wisdom, charisma, hp, ac, gold;

            if (classNum == 1)
            {

            }
        }

    }
}