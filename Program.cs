using System;

namespace Adventure

{
  

    class Program
    {
        static void Main()
        {
            StartGame startGame = new StartGame();
            // EndGame endGame = new EndGame();

            startGame.GameIntro();            
            // endGame.EndGame(); 
            Console.ReadKey();

        }
    }
}
