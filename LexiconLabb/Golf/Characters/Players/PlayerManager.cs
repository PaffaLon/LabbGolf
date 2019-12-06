using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Characters.Players
{
    public class PlayerManager
    {
        public static List<Player> Players { get; set; }
        Player Player = new Player();
        PlayerManager()
        {

        }
        public void NewPlayer(string newPlayerName)
        {
            Players.Add(Player);
        }
        public void LoadPlayer()
        {

        }
        public void DeletePlayer()
        {

        }
    }
}
