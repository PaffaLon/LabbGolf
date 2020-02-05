using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities.Characters.Players
{
    sealed class Player : Character
    {
        public Player()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            this.DefaultValuesSet = true;
        }
        //Class methods
        public void SetName(string newName)
        {
            this.Name = newName;
        }
        
    }
}
