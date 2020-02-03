

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGolf.Items
{
    public class ItemHandler
    {
        public enum ItemID
        {
            GolfBall,
            GolfHole

        }
        private bool _defaultValuesSet;
        public ItemHandler()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Costurcor Helper Methods
#region CMM
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
        #endregion
        //Class Methods
#region CM
        public void GetItem(ItemID itemID)
        {
            switch (itemID)
            {
                case ItemID.GolfBall:
                    break;
                case ItemID.GolfHole:
                    break;
                default:
                    break;
            }
        }

#endregion
    }
}
