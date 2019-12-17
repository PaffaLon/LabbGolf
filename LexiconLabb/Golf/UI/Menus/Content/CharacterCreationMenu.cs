using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.UI.Menus.Content
{
    public class CharacterCreationMenu : Menu
    {
        public string[] GetComponents = new string[1];
        public void Content()
        {
            string[] items = new string[1];
            items[0] = ("Enter Player Name: ");
            GetComponents[0] = items[0];
        }

        public string GetPlayerName()
        {
            string playerName;
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
