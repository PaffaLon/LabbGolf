using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities.Items.Items
{
    sealed class GolfHole : Item
    {
        public GolfHole()
        {

        }
        public int StartingPosition(int newPosition)
        {
            this.PositionX = newPosition;
            return this.PositionX;

        }
    }
}
