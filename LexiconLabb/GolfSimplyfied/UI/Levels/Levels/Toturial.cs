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
        /// <summary>
        /// Gathers the level resourses.
        /// </summary>
        public void LoadLevel()
        {

        }
        /// <summary>
        /// Renders physical level objects to the console.
        /// </summary>
        public void RenderLevel()
        {

        }
        
    }
}
