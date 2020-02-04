using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities
{
    abstract class Entity
    {
        protected Enum EntityID { get; set; }
        protected int PositionX { get; set; }
        protected int PositionY { get; set; }
    }
}
