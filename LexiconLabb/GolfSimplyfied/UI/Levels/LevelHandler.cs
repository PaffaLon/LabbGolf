using System;
using System.Collections.Generic;
using System.Text;
using GolfSimplyfied.UI.Levels.Levels;

namespace GolfSimplyfied.UI.Levels
{
    public class LevelHandler
    {
        //Public Initialization
        public enum LevelID
        {
            Toturial
        }

        /// <summary>
        /// LevelID and refference key.
        /// </summary>
        public static List<Enum> FeatureIDAccess { get; set; }
        //Private Initialization
        #region
        private bool _defaultValuesSet;
        private int _runLevel;
        #endregion
        //Object Initialization
        Toturial toturial = new Toturial();
        public LevelHandler()
        {
            if (_defaultValuesSet == false)
                SetDefaultValues();
        }
        //Constructor Helper Methods
#region CMM
        private void SetDefaultValues()
        {
            _defaultValuesSet = true;
        }
#endregion
        //Class Methods
        public void LoadLevel(Enum levelID)
        {
            switch (levelID)
            {
                case LevelID.Toturial:
                    _runLevel = (int)LevelID.Toturial;
                    break;
                default:
                    break;
            }
        }
        public void GetLevel()
        {
            switch (_runLevel)
            {
                case (int)LevelID.Toturial:
                    toturial.LoadLevel();
                    toturial.RenderLevel();
                    break;
                default:
                    break;
            }
        }
        private void RenderLevel()
        {

        }
    }
}
