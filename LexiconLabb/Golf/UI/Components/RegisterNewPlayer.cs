using System;
using System.Collections.Generic;
using System.Text;
using Golf.Characters.Players;

namespace Golf.UI.Components
{
    public class RegisterNewPlayer
    {
        private string playerName;
        PlayerManager playerManager = new PlayerManager();
        public void GetNewPlayerData()
        {
            Console.WriteLine("Player Name: ");
            playerName = Console.ReadLine();

            playerManager.AddPlayer(playerName);
        }

        public string PrintNewPlayrtEntryTxt()
        {
            Console.WriteLine("Enter name: ");
            Console.ReadLine();
        }
    }
}
