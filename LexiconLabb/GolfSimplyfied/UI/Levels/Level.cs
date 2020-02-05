using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.UI.Levels
{
    abstract class Level
    {
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
