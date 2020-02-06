using System;
using System.Collections.Generic;
using System.Text;
using GolfSimplyfied.Entities.Items.Items;

namespace GolfSimplyfied.UI.Levels.Levels
{
    sealed class Toturial : Level, ILevel
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
            //Resives Items bound to the level,
            //Resives UI 
        }
        /// <summary>
        /// Renders physical level objects to the console.
        /// </summary>
        public void RenderLevel()
        {

        }
        private void LevelItems()
        {
            GolfBall golfBall = new GolfBall();
            GolfHole golfHole = new GolfHole();
        }
        
    }
}
