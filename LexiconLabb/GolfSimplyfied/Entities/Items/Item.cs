using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities.Items
{
    abstract class Item : Entity
    {
        protected Enum ItemID { get; set; }
        protected bool DefaultValuesSet { get; set; }
        protected double Weight { get; set; }
    }
}
