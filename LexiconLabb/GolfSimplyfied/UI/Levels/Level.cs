using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.UI.Levels
{
    interface ILevel
    {
        public void PushBall() { }
        public void LevelWin() { }
        public void LevelDefeat() { }
        public void LoadLevel(Enum levelID) { }
        public void RenderLevel() { }
    }
    abstract class Level
    {
        //Public Initialization

        //Protected Initialization
        protected bool DefaultValuesSet { get; set; }
        
        /// <summary>
        /// Maximum swings on a level.
        /// </summary>
        protected int MaxSwings { get; set; }
        
        /// <summary>
        /// Minimum swings to win.      Level Highe Score.
        /// </summary>
        protected int MinSwings { get; set; }
        
        /// <summary>
        /// Stores the amount of swings a player has made.
        /// </summary>
        protected int CountedSwings { get; set; }
    }
}
