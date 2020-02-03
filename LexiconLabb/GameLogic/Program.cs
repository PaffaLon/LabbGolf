using System;
using SimpleGolf.Logic;
using SimpleGolf.Characters.Players;

namespace GameLogic
{
    class Program
    {
        private static bool _running;

        static void Main()
        {
            PrintMssage();
            CreateNewCharacter();
            Game game = new Game();
                 game.ReadGameControles();
           
            while (_running == true)
            {
                
            }
        }
        private static void PrintMssage()
        {
            string msg = "Enter player name: ";
            Console.Write(msg);
            Console.SetCursorPosition(msg.Length + 1, 0);
        }
        private static void CreateNewCharacter()
        {
            Player player = new Player();
                   player.NewName(Console.ReadLine());
                   player.SavePlayerObject(player);
        }
    }
}
