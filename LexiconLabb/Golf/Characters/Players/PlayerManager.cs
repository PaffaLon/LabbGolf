using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Golf.Characters.Players
{
    public class PlayerManager
    {
        public static List<Player> Players { get; set; }

        public PlayerManager()
        {
            Players = new List<Player>();
        }
        //Adds the new player object to the plyer object list.
        public void AddPlayer(Player player)
        {
            Players.Add(player);
            Debug.Print("---");
            Debug.Print("New Player Object: " + player.ID);
            Debug.Print("Player name: " + player.Name);
        }
        public void LoadPlayer()
        {

        }
        public void DeletePlayer()
        {

        }
    }
}
