using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGolf.Characters.Players
{
    interface IGetPlayer
    {
        public void GetPlayer();
    }
    sealed class Player : Character, IGetPlayer
    {
        private static List<Player> Players = new List<Player>();
        public int SwingStrength { get; set; }
        public int CountSwings { get; set; } = 0;

        public Player()
        {
            
        }
        //Constructor Helper Methods
#region CMM
        private void SetDefaultValues()
        {

        }
#endregion
        //Class Methods
#region CM
        public void GetPlayer()
        {

        }
        public void NewName(string playerName)
        {
            this.Name = playerName;
        }
        public void SavePlayerObject(Player player)
        {
            Players.Add(player);
        }
#endregion
    }
}
