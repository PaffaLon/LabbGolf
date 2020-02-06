using System;
using System.Collections.Generic;
using System.Text;
using GolfSimplyfied.Entities.Characters.Players;
using GolfSimplyfied.Entities.Items;
using GolfSimplyfied.Entities.Items.Items;

namespace GolfSimplyfied
{
    internal class GameEngine
    {
        public enum poco
        {
            GameControles,
            RunLevel,
            GetItem,
            GetPlayer
        }
        private bool WinConditionMet { get; set; }

        Player player = new Player();
        GolfBall golfBall = new GolfBall();
        GolfHole GolfHole = new GolfHole();
        internal GameEngine()
        {

        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            GolfHole.StartingPosition(10);
        }
        //Class Methods
        public void GameControles()
        {
            ConsoleKeyInfo cki;

            cki = Console.ReadKey();

            while (WinConditionMet == false)
            {
                int posX;
                if (cki.Key.GetHashCode() == 38)//ArrpwUp
                    posX = player.IncreaseSwingStrength();

                else if (cki.Key.GetHashCode() == 40)//Down
                    player.DecreseSwingStrength();

                else if (cki.Key.GetHashCode() == 32)//Space
                {
                    golfBall.SetPositionX();
                    player.SwingGolfClub();
                }
                else
                {
                    
                }
            }
        }
        public void UpdateUI()
        {

        }

    }
}
