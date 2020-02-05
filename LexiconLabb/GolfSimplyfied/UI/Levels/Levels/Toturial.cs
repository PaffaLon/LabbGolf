using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.UI.Levels.Levels
{
    sealed class Toturial : Level
    {
        public Toturial()
        {
            if (this.DefaultValuesSet == true)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            this.DefaultValuesSet = true;
        }
        //Class Methods
        public void Load()
        {

        }
    }
}
