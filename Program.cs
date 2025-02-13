using System;

namespace Adventure

{
    class Program
    {
        static void Main()
        {
            //set console window width, height
            Console.SetWindowSize(120, 40);

            //intro screen, name, and class information gathered
            StartGame startGame = new StartGame();

            //start player at world map, allow for movement and interaction
            TravelMap travelMap = new TravelMap();
        
            startGame.GameIntro();
            travelMap.StartTownSquare();
            Console.ReadKey();

        }
    }
}
