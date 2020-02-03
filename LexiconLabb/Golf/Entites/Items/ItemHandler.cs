using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Entites.Items
{
    public class ItemHandler
    {
        private bool _defaultValuesSet;
        public ItemHandler()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
        //Class Methods
        public void LoadItem()
        {

        }
        public void GetItem()
        {

        }
    }
}
