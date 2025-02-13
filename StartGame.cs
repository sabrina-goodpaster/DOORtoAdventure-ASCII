﻿using System;
using TextAdventure;

public class StartGame()
{

    public void GameIntro()
    {
        Console.Title = "DOOR to Adventure";
        Console.ForegroundColor = ConsoleColor.Cyan;
        string title = @"
                                                                            :=@@  
                       @@@@@                                              *@@@@@ 
                      @@@@@@@                                            %@@@@@@ 
                        @@@@@@@@                                       @@@@@@@   
                          @@@@@@@@                                   %@@@@@@@    
                           @@@@@@@@*.     @@@@@@       @@@@        *@@@@@@@      
                             @@@@@@%%%@@@@@@@            @@@@@@@%%%%@@@@@@       
                               @@@@@@@@@@                     @@@@@@@@@          
                                %@@@@@#--#@                 %#=:#@@@@@@          
                                @@@@#=#%+:-#@             @#=:-#@+*@@@@          
                                @@@@%-:=@%=::#@         @%-::#@*::*@@@@          
                                @@@  @*::*@%-:-#@     @%-::*@%-:=@@  @@@         
                                @@    @%=:-#@#-::*@@@#=::*@%=:-#@     @@         
                                @       @#-:-%@#::+#-::+@@+::*@@      @@
         ____   ___   ___  ____    _             _       _                 _                  
        |  _ \ / _ \ / _ \|  _ \  | |_ ___      / \   __| |_   _____ _ __ | |_ _   _ _ __ ___ 
        | | | | | | | | | | |_) | | __/ _ \    / _ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
        | |_| | |_| | |_| |  _ <  | || (_) |  / ___ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/
        |____/ \___/ \___/|_| \_\  \__\___/  /_/   \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|

                                     @@*:::-#@@#:::=#::*@@%-:::+@@               
                                   @@*::::*@@%-::-#@%=::-#@@#-:::+%@             
                                  @*::::+@@@=:::*@   @#:::-%@@#::::+@@           
                                @%:::.-#@@*:::=%@     @@=:::=@@@-::::*@          
                               @@-:..=@%+::::#@         @%-:::-#@*::::#@         
                               @=:::##-::::+@@            @*:::::+#-::=%         
                              %+::-=:::::-%@               @%=:::::-=::+@        
                             ##-::::::-+%@                   @%*=:::::::%@       
                             @=::-+#%@@                         @@@#+=:::@@      
                            @%#%@@                                   @@%%#@  ";

        Console.WriteLine(title);
        Console.ResetColor();
        Console.WriteLine("\n\n\n");

        //character name and class selection gathered
        Character nameCharacter = new Character();
        nameCharacter.NameCharacter();

         //go back to Program.cs for next steps
    }
}