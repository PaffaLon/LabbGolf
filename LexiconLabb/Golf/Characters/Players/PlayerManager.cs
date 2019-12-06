using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Characters.Players
{
    public class PlayerManager
    {
        public static List<Player> Players { get; set; }
        Player Player = new Player();
       public PlayerManager()
        {

        }
        public void AddPlayer(string playerName)
        {
            Player.Name = playerName;
            //To Do
            //GeneratePlayerStats();
        }
        public void NewPlayer()
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
