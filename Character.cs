using System;



namespace TextAdventure
{
    public class Character
    {
        public static string? characterName = "";
        int classSelection = 0;
        public static string myClass = "";
        public static int meleeBonus, rangedBonus, spellBonus, hp, ac;
        public static int gold = 400;
        public static int charLevel = 1;
        public static string weapon = "Nothing";
        public static string armor = "Nothing";

        //ask player for a name between 3-20 characters, and save it
        public void NameCharacter()
        {

            while (characterName!.Length < 3 || characterName!.Length > 20)
            {
                Console.WriteLine("Please enter your character's name (between 3 and 20 characters)");
                characterName = Console.ReadLine();
            }
            
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

            string? classAsString = "";

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
            else
            {
                meleeBonus = -2;
                rangedBonus = 2;
                spellBonus = 5;
                hp = 7;
                ac = 10;
            }

        }
    }
}
