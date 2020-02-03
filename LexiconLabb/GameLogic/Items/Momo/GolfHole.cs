using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGolf.Items
{
    sealed class GolfHole : Item
    {
        public GolfHole()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        private void SetDefaultValues()
        {
            this.PostionX = 100;
            DefaultValuesSet = true;
        }
    }
}
