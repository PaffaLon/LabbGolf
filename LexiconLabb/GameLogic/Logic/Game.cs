using System;
using System.Collections.Generic;
using System.Text;
using SimpleGolf.Characters.Players;
using SimpleGolf.Items;

namespace SimpleGolf.Logic
{
    public class Game
    {
        ConsoleKeyInfo cki;

        PlayerHandler playerHandler = new PlayerHandler();
        ItemHandler itemHandler = new ItemHandler();
        public Game()
        {

        }
        public void PrintGameText()
        {
            
        }
        public void ReadGameControles()
        {
            cki = Console.ReadKey();
            if (cki.Key.GetHashCode() == 38)//Key UP
            {
                itemHandler.GetItem(ItemHandler.ItemID.GolfBall);
            }
            else if (cki.Key.GetHashCode() == 40)//Key DOWN
            {

            }
            else if (cki.Key.GetHashCode() == 32)// Key SPACE
            {
                
            }
            else
            {

            }
        }
    }
}
