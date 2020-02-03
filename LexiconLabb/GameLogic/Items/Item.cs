using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGolf.Items
{
    abstract class Item
    {
        protected bool DefaultValuesSet { get; set; }
        /// <summary>
        /// An Items position on the Y-axis.
        /// </summary>
        protected int PositionY { get; set; }
        /// <summary>
        /// An Items position on the X-axis.
        /// </summary>
        protected int PostionX { get; set; }
    }
}
