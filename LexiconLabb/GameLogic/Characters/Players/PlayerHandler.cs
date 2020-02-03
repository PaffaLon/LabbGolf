using System;
using System.Collections.Generic;
using System.Text;
using SimpleGolf.Characters.Players;
namespace SimpleGolf.Characters.Players
{
    public class PlayerHandler
    {
        private bool _defaultValuesSet;

        Player player = new Player();
        public PlayerHandler()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
#region CMM
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
#endregion
#region CM
        //Class Methods
        public void GetPlayerObject()
        {
            player.GetPlayer();   
        }
        
#endregion
    }
}
