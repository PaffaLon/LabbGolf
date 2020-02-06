using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities
{
    abstract class Entity
    {
        protected Enum EntityID { get; set; }
        
        /// <summary>
        /// The entities position on the X axis. __
        /// </summary>
        protected int PositionX { get; set; }
        
        
        /// <summary>
        /// The entities position on the Y axis. |
        /// </summary>
        protected int PositionY { get; set; }
    }
}
