using System;
using System.Collections.Generic;
using System.Text;
using Golf.Entites.Characters.Players;

namespace Golf.Entites.Characters.Players
{
    public class PlayerHandler
    {
        
        //public static List<Player> Players { get; set; }
        private bool _defaultValuesSet;
        
        Player player = new Player();
        public PlayerHandler()
        {
            //if (Players == null)
            //    Players = new List<Player>();

            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //construcor Helper Methods
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
        //Class Methods
        public void LoadPlayer()
        {

        }
        public void GetPlayer()
        {

        }
        //Creats a new player object from new player data.
        public void NewPlayer()
        {

        }
        //Adds a new player object to a collection of players.
        public void AddPlayer()
        {

        }
    }
}
