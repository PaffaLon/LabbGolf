using System;
using System.Collections.Generic;
using System.Text;

namespace Golf.Entites.Characters
{
    public class CharacterHandler
    {
        private bool _defaultValuesSet;
        public CharacterHandler()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
#region CHH
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
#endregion
        //Class Methods
        public void LoadCharacter()
        {

        }
        public void GetCharacter()
        {

        }
    }
}
