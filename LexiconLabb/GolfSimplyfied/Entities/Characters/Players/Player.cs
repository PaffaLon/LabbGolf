using System;
using System.Collections.Generic;
using System.Text;

namespace GolfSimplyfied.Entities.Characters.Players
{
    sealed class Player : Character
    {
        private int _swingStrength;
        private int _swingStrengthMax = 10;
        private int _swingStrengthMin = 1;
        public Player()
        {
            if (this.DefaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
        private void SetDefaultValues()
        {
            this.DefaultValuesSet = true;
        }
        //Class methods
        public void SetName(string newName)
        {
            this.Name = newName;
        }
        public int IncreaseSwingStrength()
        {
            _swingStrength += 1;
            CheckSwingStrength(_swingStrength);
            return _swingStrength;
        }
        public void DecreseSwingStrength()
        {
            _swingStrength -= 1;
            CheckSwingStrength(_swingStrength);
        }
        private void CheckSwingStrength(int value)
        {
            if (value > _swingStrengthMax)
                _swingStrength = _swingStrengthMax;

            if (value < _swingStrengthMin)
                _swingStrength = _swingStrengthMin;
        }

        public void SwingGolfClub()
        {
            
            
        }
    }
}
